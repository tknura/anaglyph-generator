﻿using System;
using System.Threading;

// Autor: Tomasz Knura INF SSI gr.5 sem.5
// Temat: Generator anaglifów
// Wersja: 1.0
namespace anaglyph_generator {
    public class AnaglyphGenerationTask {
        private static byte[][] bitmaps;
        private ManualResetEvent doneEvent;
        private int startPoint;
        private int endPoint;
        private static Action<byte[], byte[], byte[], int, int> generationFunction;

        public AnaglyphGenerationTask(int startPoint, int endPoint, ManualResetEvent doneEvent) {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.doneEvent = doneEvent;
        }

        public static void setBitmaps(byte[][] b) {
            bitmaps = b;
        }

        public static void setGenerationFunction(Action<byte[], byte[], byte[], int, int> function) {
            generationFunction = function;
        }

        public void ThreadProc(object callback) {
            try {
                generationFunction(bitmaps[0], bitmaps[1], bitmaps[2], startPoint, endPoint);
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            doneEvent.Set();
        }
    }
}
