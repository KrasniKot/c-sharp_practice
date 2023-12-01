// Prints "hello world" 3 times and then the first 5 characters
using System;
using System.Linq;

namespace HelloWorld {
    class PrintString {
        static void Main(string[] args) {

            Console.WriteLine(string.Join("\n", Enumerable.Repeat("hello world", 3)));
            Console.WriteLine(new string("hello world".Take(5).ToArray()));
        }
    }
}
