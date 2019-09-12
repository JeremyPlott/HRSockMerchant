using System;
using System.Collections.Generic;
using System.Linq;

namespace HRSockMerchant {
    class Program {
        static void Main(string[] args) {

            var ar = new int[] { 1, 1, 1, 2, 2, 3, 4, 5, 5, 5, 5, 6, 6, 6 }; // 5 pairs - 1, 2, 5, 5, 6

            int n = ar.Length;

            var dict = new Dictionary<int, int>();
            foreach (int i in ar) {
                if (dict.ContainsKey(i))
                    dict[i]++;
                else
                    dict.Add(i, 1);
            }

            int sum = 0;
            foreach(var entry in dict) {
                int pairs = entry.Value / 2;
                sum += pairs;
            }
            Console.WriteLine(sum);
        }
    }
}
