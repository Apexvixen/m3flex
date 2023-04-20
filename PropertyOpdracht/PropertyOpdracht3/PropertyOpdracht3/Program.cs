using System;
using System.Windows.Markup;

namespace PropertyOpdracht3
{
    internal class Mens
    {
        private int leeftijd;

        public int Leeftijd
        {
            get
            {
                return leeftijd;
            }
            set
            {
                if (value > leeftijd)
                {
                    leeftijd = value;
                    Console.WriteLine("nope you young fuck");
                }
                else
                {
                    Console.WriteLine("no not happening");
                }
            }
        }

        public Mens(int leeftijd)
        {
            this.leeftijd = leeftijd;
        }
    }
}