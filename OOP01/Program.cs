using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    class Ember
    {
        public string nev;
        public int eletkor;

        public string Bemutatkozas()
        {
            string valasz = $"{nev} vagyok {eletkor} éves";
            return valasz;

            //string valasz = nev + " vagyok " + eletkor + " éves ";
            //return valasz2;

            //return $"{nev} vagyok {eletkor} éves";
        }
    }

    class Teglalap
    {
        public int a;
        public int b;

        public int Kerulet()
        {
            return 2*a+2*b;
        }

        public int Terulet()
        {
            return a*b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ember pisti = new Ember();
            Ember eva = new Ember();

            pisti.nev = "Nagy Pisti";
            pisti.eletkor = 20;

            eva.nev = "Kis Éva";
            eva.eletkor = 18;

            Console.WriteLine(pisti.Bemutatkozas());
            Console.WriteLine(eva.Bemutatkozas());

            Teglalap t = new Teglalap();

            t.a = int.Parse(Console.ReadLine());
            t.b = int.Parse(Console.ReadLine());

            Console.WriteLine("Kerület: {0} Terület: {1}",t.Kerulet(),t.Terulet());

            Console.ReadKey();
        }
    }
}
