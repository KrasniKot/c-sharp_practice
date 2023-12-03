// Assigns a random number to number
// Writes to the console

using System;

namespace IELF {
    class PositiveNegative {
        static void Main(string[] args) {

            Random r = new Random();
            int number = r.Next(-100, 100);

            if (number < 0) Console.WriteLine($"{number} is negative");
            else if (number == 0) Console.WriteLine($"{number} is zero");
            else Console.WriteLine($"{number} is positive");
        }
    }
}
