using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Wie viel Geld haben Sie ? ");
            int a = Convert.ToInt32(Console.ReadLine());
            Program.ZSK(a);

            Console.ReadLine();

        }
        
        static void ZSK(int euro)
        {
            int anzKuh, anzSchaf, anzZiege, anzKlziege, rest;
            
            
            anzKuh = euro / 2800;
            rest = euro % 2800;
            euro = rest;

            anzSchaf = euro / 650;
            rest = euro % 650;
            euro= rest;

            anzZiege = euro / 500;
            rest = euro % 500;
            euro = rest;

            anzKlziege= euro / 50;
            rest = euro % 50;
            euro = rest;

            Console.WriteLine($" Die Anzahl von Kühe : {anzKuh}\n Die Anzahl von Schafe : {anzSchaf }\n Die Anzahl von Ziegen {anzZiege}\n Die Anzahl von kleinen Zeigen {anzKlziege}");

        }

       
    }
}










