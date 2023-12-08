// Prints the alphabet in hex

using System;

namespace IELF {
    class HexLog {
        static void Main(string[] args) {
            for (int i = 1; i <= 26; i++) Console.WriteLine($"{i}: {(i + 96):X}");
        }
    }
}
