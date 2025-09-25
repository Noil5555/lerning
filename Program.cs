using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hallo
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Einsehen & Einzahlem & Abheben
            string logging = "1111";
            string username = "";
            string userimpout = "";
            int pin = 0;


            while (logging == "1111")
            {
                Console.WriteLine(
                    "Was möchtest du machen?   1) login   2) mit einem Mitarbeiter sprechen   3) Terminmwunsch    4) Exit");
                logging = Console.ReadLine();
            }

            while (logging == "1")
            {
                Console.WriteLine("1) einloggen    2) regestrieren   3) exit");
                userimpout = Console.ReadLine();

                if (userimpout == "1")
                {
                    bnak myKonto = new bnak(moneten: 100.0f,passwd: pin, user: username);
                    myKonto.login(username, pin);
                    
                    Console.WriteLine("was möchtest du machen?   1) geld einzahlen (lecker)   2) geld ansehen (gut)   3) geld abheben (ekelhaft)");
                    userimpout = Console.ReadLine();

                    if (userimpout == "1")
                    {
                        myKonto.einzahlen();
                        logging = "1111";
                    } else if (userimpout == "2")
                    {
                        myKonto.einsehen();
                        logging = "1111";
                    } else if (userimpout == "3")
                    {
                        myKonto.cashout();
                        logging = "1111";
                    }
                    else
                    {
                        logging = "1111";
                    }
                    
                }   
                else if (userimpout == "2")
                {
                    Console.WriteLine("Was soll dein Username sein?");
                    username = Console.ReadLine();
                    
                    Console.WriteLine("Was soll deine Pin sein?");
                    pin = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Schreibe Quit, um den Screen zu verlassen");
                    userimpout = Console.ReadLine().ToLower();
                    
                    if (userimpout == "quit")
                    {
                        Console.WriteLine("Was möchtest du machen?   1) login   2) mit einem Mitarbeiter sprechen   3) Terminmwunsch    4) Exit");
                        logging = Console.ReadLine(); 
                    }
                }
            }

            while (logging == "4")
            {
                Console.WriteLine("Verpisst dich");
                logging = "0";
            }

            while (logging == "2")
            {
                Console.WriteLine("Verpisst dich");
                logging = "0";
            }

            while (logging == "3")
            {
                Console.WriteLine("Verpisst dich");
                logging = "0";
            }
            
        }
        
    }
}