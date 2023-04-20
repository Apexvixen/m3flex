using PropertyOpdracht1;
using System;

namespace PropertyOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, biatch!");

            Hond huisdier = new Hond("schield pad");

            huisdier.Naam = "magniet" ; ;//deze mag niet werken!
        }
    }
}