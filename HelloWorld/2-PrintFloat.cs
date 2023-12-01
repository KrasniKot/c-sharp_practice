// Prints a float with presition of 2 digits.

using System;

namespace HelloWorld {
    class PrintFloat {
        static void Main(string[] args) {

            Console.WriteLine($"{float.Parse(args[0]):F2}");
        }
    }
}

