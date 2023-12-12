// Print all the possible combinations of two digit numbers

using System;

namespace IELF {
    class LogComb {
        static void Main(string[] args) {

            for (int i = 0; i <= 88; i++)
                if (i / 10 < i % 10) Console.Write($"{i}, ");
            Console.WriteLine("89");
        }
    }
}
