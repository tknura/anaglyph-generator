﻿using System;
using System.Threading;

namespace anaglyph_generator {
    public class AnaglyphGenerationTask {
        private static byte[][] bitmaps;
        private ManualResetEvent doneEvent;
        private int startPoint;
        private int endPoint;
        private static Action<byte[][], int, int> generationFunction;

        public AnaglyphGenerationTask(int startPoint, int endPoint, ManualResetEvent doneEvent) {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.doneEvent = doneEvent;
        }

        public static void setBitmaps(byte[][] b) {
            bitmaps = b;
        }

        public static void setGenerationFunction(Action<byte[][], int, int> function) {
            generationFunction = function;
        }

        public void ThreadProc(object callback) {
            generationFunction(bitmaps, startPoint, endPoint);
            doneEvent.Set();
        }
    }
}