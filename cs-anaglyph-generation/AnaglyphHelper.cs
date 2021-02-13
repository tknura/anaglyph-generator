using System;

// Autor: Tomasz Knura INF SSI gr.5 sem.5
// Temat: Generator anaglifów
// Wersja: 1.0
namespace CsAnaglyphGenerationHelper
{
    static public class CsAnaglyphHelper {

        /* Funkcja tworząca angalif w zadanym zakresie
         * Parametry:
         *  leftPic - tablica byte zawierająca dane lewej bitmapy
         *  rightPic - talica byte zawierająca dane prawej bitmapy
         *  result - tablica byte do której zapisany zostanie wynikowy anaglif
         *  startPoint - punkt w tablicy danych zdjęć w którym rozpocząć tworzenoe anaglifu
         *  endPoint - punkt w tablicy danych zdjęć w którym zakończyć tworzenie anaglifu
         */
        static public void makeAnagliph(byte[] leftPic, byte[] rightPic, byte[] result, int startPoint, int endPoint) {
            for (int i = startPoint;i < endPoint; i++) {
                if(i % 3 == 0 || i % 3 == 1) {
                    result[i] = rightPic[i]; // B or G
                } else if (i % 3 == 2) {
                    result[i] = Convert.ToByte(0.299 * leftPic[i] + 0.587 * leftPic[i - 1] + 0.114 * leftPic[i - 2]); //R
                }
            }
        }
    }
}
