// Program that prints the are 10 types of people using string interpolation
using System;

namespace HelloWorld {
  class TenTypes {
    static void Main(string[] args) {

      string there = "There are ";
      int ten = 10;
      string types = " types of people";

      Console.WriteLine($"{there}{ten}{types}");
    }
  }
}
