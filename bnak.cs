using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hallo
{
    class bnak
    {
        public float Moneten { get; private set; }
        public string User {get; private set;}
        public int Passwd {get; private set;}

        public bnak(float moneten, string user, int passwd)
        {
            Moneten = moneten;
            User = user;
            Passwd = passwd;
        }


        public void login(string user, int passwd)
        {   Console.WriteLine("was ist dein User?");
            user = Console.ReadLine();
            
            Console.WriteLine("was ist dein Passwd?");
            passwd = int.Parse(Console.ReadLine());
            
            if (passwd == Passwd && user == User)
            {
                Console.WriteLine("Welcome " + User + "!");
            }

            while (user != User || passwd != Passwd)
            { 
                Console.WriteLine("das passwort, oder der User ist nicht richtig! Bitte versuche es nochmal:");
            }
        }

        public void einsehen()
        {
            Console.WriteLine("Das ist dein jetziges Guthaben: "  + Moneten);
        }

        public void einzahlen()
        {
            Console.WriteLine("Wie viel Geld möchtest du einzahlen?");
            float money =  float.Parse(Console.ReadLine());
            Moneten = money + Moneten;
            Console.WriteLine("das ist dein aktuelles Guthaben: " + Moneten);
        }

        public void cashout()
        {
            Console.WriteLine("Wie viel Geld möchtest du verlieren?");
            float cashout = float.Parse(Console.ReadLine());
            Moneten =  Moneten - cashout;
            Console.WriteLine("das ist dein aktuelles Guthaben: " + Moneten);
        }
    } 
}