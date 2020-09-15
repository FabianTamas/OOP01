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

        public int TKerulet()
        {
            return 2 * a + 2 * b;
        }

        public int TTerulet()
        {
            return a * b;
        }
    }

    class Kor
    {
        public int r;
        public double pi;

        public double KKerulet()
        {
            return 2 * r * Math.PI;
        }

        public double KTerulet()
        {
            return Math.Pow(r,2) * Math.PI;
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

            Console.WriteLine("A téglalap a oldala:");
            t.a = int.Parse(Console.ReadLine());
            Console.WriteLine("A téglalap b oldala:");
            t.b = int.Parse(Console.ReadLine());

            Console.WriteLine("Téglalap Kerület: {0} \t Téglalap Terület: {1}",t.TKerulet(),t.TTerulet());

            Kor k = new Kor();

            Console.WriteLine("A kör kerülete:");
            k.r = int.Parse(Console.ReadLine());

            Console.WriteLine("Kör Kerület: {0} \t Kör Terület: {1}",k.KKerulet(),k.KTerulet());

            Console.ReadKey();
        }
    }
}
