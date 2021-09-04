﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Buch lehrbuch = new Buch("Mathematik für Dummies", 250);
            Console.WriteLine(lehrbuch.AnzahlSeiten);
            Console.WriteLine(lehrbuch.Titel);

            Console.ReadKey();
        }
    }

    class Buch
    {
        //Eigenschaften
        public string Titel { get; set; }
        public int AnzahlSeiten { get; set; }

        //Konstruktor
        public Buch(string _titel, int _anzahlSeiten)
        {
            Titel = _titel;
            AnzahlSeiten = _anzahlSeiten;
        }
    }
}
