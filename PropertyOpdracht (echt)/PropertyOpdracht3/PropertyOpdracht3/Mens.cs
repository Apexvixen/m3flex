﻿using System;
using System.Windows.Markup;

namespace PropertyOpdracht3
{
    internal class Mens
    {
        private int leeftijd;

        public int Leeftijd
        {
            get {
                return leeftijd;
            }
            set
            {
                if(value > leeftijd)
                {
                    leeftijd = value;
                    Console.WriteLine("you like!");
                }
                else
                {
                    Console.WriteLine("don't like");
                }
            }
        }

        public Mens(int leeftijd)
        {
            this.leeftijd = leeftijd;
        }
    }
}