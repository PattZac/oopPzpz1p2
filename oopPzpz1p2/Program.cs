using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPzpz1p2
{
    class GeometrijskiLik
    {
        int brojStranica;
        double[] stranice = new double[10];

        public int BrojStranica { get => brojStranica; set => brojStranica = value; }
        public double[] Stranice { get => stranice; set => stranice = value; }

        public void UcitajStranice()
        {
            for (int i = 0; i < BrojStranica; i++)
            {
                Console.Write("Upišite duljinu " + (i + 1) + ". stranicu: ");
                string s = Console.ReadLine();
                Stranice[i] = Convert.ToDouble(s);
            }
        }
        public double Opseg()
        {
            double n = 0;
            for (int i = 0; i < this.BrojStranica; i++)
            {
                n += this.Stranice[i];
            }
            return n;
        }
    }
    class Trokut : GeometrijskiLik
    {
        public Trokut()
        {
            BrojStranica = 3;
        }
    }
    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut()
        {
            BrojStranica = 4;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trokut t = new Trokut();
            t.UcitajStranice();
            Console.WriteLine("Opseg trokuta je " + t.Opseg());
            Cetverokut c = new Cetverokut();
            c.UcitajStranice();
            Console.WriteLine("Opseg četverokuta je " + c.Opseg());
            Console.ReadKey();
        }
    }
}
