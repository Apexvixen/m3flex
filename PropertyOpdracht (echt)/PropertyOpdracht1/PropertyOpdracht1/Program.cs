using System;

namespace PropertyOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello MF");

            Persoon persoon = new Persoon();

            persoon.Naam = "dragan" ; ;//maak deze string aan als property in persoon, gebruik get set
            persoon.Leeftijd = 10 ;//maak deze int aan als property in persoon, gebruik get set
        }
    }
}