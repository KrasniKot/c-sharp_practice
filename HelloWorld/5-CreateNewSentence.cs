// Takes part of a sentence

using System;

namespace HelloWorld {
    class SubString {
        static void Main(string[] args) {

            string s =
                "C# is a statically-typed, object-oriented programming language " +
                "designed for building robust and efficient applications on the .NET framework, " +
                "characterized by a strong type system and modern language features.";
            int start = s.IndexOf("object-oriented");
            int end = s.IndexOf(" designed");

            Console.WriteLine(s.Substring(start, end - start));
        }
    }
}
