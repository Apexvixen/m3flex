using PropertyOpdracht1;
using System;

namespace PropertyOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello to hell");

            Hond huisdier = new Hond("doggo");

            huisdier.Naam = "magniet" ; ;//deze mag niet werken!
        }
    }
}