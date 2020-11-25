using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTriangoli
{
    public class MetodiTriangoli
    {
        public static double Lato()
        {
            Console.Write($"Inserisci un lato del triangolo:");
            double lato = double.Parse(Console.ReadLine());
            return lato;
        }

        public static string OutputTrangolo(double l1, double l2, double l3)
        {
            string triangolo = null;
            if (l1 == l2 && l1 == l3)
            {
                triangolo = "equilatero";
            }
            else if (l1 == l2 || l1 == l3 || l2 == l3)
            {
                triangolo = "isoscele";
            }
            else
            {
                triangolo = "scaleno";
            }


            return triangolo;
        }

        public static double Perimetro(double l1, double l2, double l3)
        {
            return l1 + l2 + l3;

        }
    }
}
