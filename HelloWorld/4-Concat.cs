// print 3 times a concatenated string
using System;
using System.Text;

namespace HelloWorld {
    class ConcString {
        static void Main(string[] args) {

            string hello = "Hello";
            string world = " World";

            StringBuilder hW = new StringBuilder("Hello");
            hW = hW.Append(world);

            Console.WriteLine(hello + world);
            Console.WriteLine(string.Concat(hello, world));
            Console.WriteLine(hW);
            
        }
    }
}
