// Print the last digit of a number

using System;

namespace IELF {
    class LastDigit {
        static void Main(string[] args) {

            Random r = new Random();
            int n = r.Next(-1000, 1000);

            Console.Write($"Last digit of {n} is {n % (10)} and ");
            if (n % (10) > 5) Console.WriteLine("is greater than 5");
            else if (n % (10) == 0) Console.WriteLine("is zero");
            else if (n % (10) != 0 && n (10) < 6) Console.WriteLine("and is less than 6 and not 0");
        }
    }
}
