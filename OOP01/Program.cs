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

            Console.ReadKey();
        }
    }
}
