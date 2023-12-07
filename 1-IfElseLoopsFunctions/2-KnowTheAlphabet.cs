// Program that prints the alphabet in lowecase

using System;

namespace IELF {
    class KnowTheAlphabet {
        static void Main(string[] args) {

            for (int c = 97; c <= 123 && c > 96; c++) {
                if (c == 123) c = 10;
                Console.Write((char)c);
            }
        }
    }
}
