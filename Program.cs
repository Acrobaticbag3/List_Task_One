using System;
using System.Collections.Generic;
    class Program {

        public static void Main (string[] args) {
            List<int> minLista = new List<int>();
            minLista.Add(11); minLista.Add(5);
            minLista.Add(12); minLista.Add(3);
            minLista.Add(6); minLista.Add(3);
            
            minLista.Sort();
            SkrivUt(minLista);

            Console.WriteLine("= = = = = = = = = = = =");

            Console.WriteLine("Största tal: " + Största(minLista));
            Console.WriteLine("Minsta tal: " + Minsta(minLista));

            Console.ReadKey();
        }

        static int Minsta(List<int> listan) {
            int lowestNum = listan[0];

            for (int i = 1; i < listan.Count; i++){
                if (listan[i] < lowestNum) {
                    lowestNum = listan[i];
                }
            }

            return lowestNum;
        }

        static int Största(List<int> listan) {
            int biggestNum = listan[0];

            for (int i = 1; i < listan.Count; i++){
                if (listan[i] > biggestNum) {
                    biggestNum = listan[i];
                }
            }

            return biggestNum;
        }

        static void SkrivUt(List<int> listan) {
            foreach (int element in listan) {
                Console.WriteLine(element);
            }
        }
    }