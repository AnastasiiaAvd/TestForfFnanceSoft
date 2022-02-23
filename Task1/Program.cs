using System;
using BLL;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringValue = "qwerty";

            // todo можно было бы сделать и более изящнее, но я торопилась :)
            Console.WriteLine(stringValue.ReverseString());
        }
    }
}
