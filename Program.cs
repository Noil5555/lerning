using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Holz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string logging = "";
            string eiche = "eiche";
            string lärche = "lärche";
            string fichte = "fichte";
            string buche = "buche";
            string birke = "birke";
            string tanne = "tanne";
            string userinput = "";

            List<string> baume = new List<string>
            {
                "Eiche",
                "Lärche",
                "Fichte",
                "Buche",
                "Birke",
                "Tanne"
            };
            
            Random r = new Random();

            Console.WriteLine("Willkommen in dem Game der Zimmerer\n"+
                              "Das Ziehl dieses Spiels ist es das Holz, an Hand des Ausehens den richtigen Namen zuzurodnen\n"+
                              "Wenn du bereit bist zum Start schreibe: START zum starten oder EXIT um das Programm zu beenden");

            logging = Console.ReadLine().ToLower();

            if (logging == "start")
            {

            } else if (logging == "exit")
            {
                Console.WriteLine("Auf wieder sehen");
                logging = "";
            }
            else
            {
                Console.WriteLine("Bitte schreibe entweder START um zu starten oder EXIT zum Programm beenden");
                logging = Console.ReadLine().ToLower();
            }

            arten vergleicher = new arten();
            
            while (baume.Count > 0)
            {
                int index = r.Next(baume.Count);
                string temp = baume[index];

                Console.WriteLine("Was ist dieses Holz? " + temp);
                baume.RemoveAt(index);

                userinput = Console.ReadLine().ToLower();

                if (vergleicher.richtiger(userinput, temp))
                {
                    Console.WriteLine("du sehr gut");
                }
                else
                {
                    Console.WriteLine("Nope du looser, her ist es: " + temp);
                }
            }
        }
    }
}
