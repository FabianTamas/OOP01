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
        private int a;
        private int b;

        public Teglalap(int aOldal, int bOldal)
        {
            a = aOldal;
            b = bOldal;
        }

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
        private int r;

        public Kor(int sugar)
        {
            if (sugar<1)
            {
                r = 1;
            }
            else r = sugar;
        }

        private double KKerulet()
        {
            return 2 * r * Math.PI;
        }

        private double KTerulet()
        {
            return Math.Pow(r,2) * Math.PI;
        }

        public void AdatokKiirasa()
        {
            Console.WriteLine("Sugár: {0}", r);
            Console.WriteLine("Kerület: {0}", KKerulet());
            Console.WriteLine("Terület: {0}", KTerulet());
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

            Console.Write("Téglalap a oldala: ");
            int aOldal = int.Parse(Console.ReadLine());
            Console.Write("A téglalap b oldala: ");
            int bOldal = int.Parse(Console.ReadLine());
            Teglalap t = new Teglalap(aOldal, bOldal);

            //Console.Write("A téglalap a oldala: ");
            //t.a = int.Parse(Console.ReadLine());
            //Console.Write("A téglalap b oldala: ");
            //t.b = int.Parse(Console.ReadLine());

            Console.WriteLine("Téglalap Kerület: {0} \t Téglalap Terület: {1}",t.TKerulet(),t.TTerulet());

            Console.Write("A kör sugara: ");
            int sugar = int.Parse(Console.ReadLine());
            Kor k = new Kor(sugar);

            //Console.WriteLine("A kör sugara:");
            //k.r = int.Parse(Console.ReadLine());

            //Console.WriteLine("Kör Kerület: {0} \t Kör Terület: {1}",k.KKerulet(),k.KTerulet());ű
            
            Console.WriteLine("Kör adatai:");
            k.AdatokKiirasa();

            Console.ReadKey();
        }
    }
}
