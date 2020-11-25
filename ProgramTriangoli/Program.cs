using System;
using ClassTriangoli;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTriangoli
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1 = MetodiTriangoli.Lato();
            double l2 = MetodiTriangoli.Lato();
            double l3 = MetodiTriangoli.Lato();
            string triangolo = MetodiTriangoli.OutputTrangolo(l1, l2, l3);
            double? perimetro = MetodiTriangoli.Perimetro(l1, l2, l3);
            Console.ReadLine();
        }
    }
}
