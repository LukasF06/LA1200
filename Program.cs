using System;

namespace Modul_403_Auftrag_1200
{
    class Program
    {
        static void Main(string[] args)
        {
     while (true)
     {

            
          try
          {

            
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("!!!Willkommen zum Zahlenerrater 1.0!!!");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Bitte geben Sie ihren Namen ein:");
            Console.ForegroundColor = ConsoleColor.White; 

            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("Hallo " + name + "!");

            Random rand = new Random();
            int rnd = rand.Next(1, 100);

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Eine zufällige Zahl wird JETZT generiert... Bitte warten!");
            Console.WriteLine("... ... ...");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Eine zufällige Zahl wurde generiert!");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 100 ein:");
            Console.ForegroundColor = ConsoleColor.White;

            string userEingabe = Console.ReadLine();
            int userZahl = Int32.Parse(userEingabe);
            int versuche = 0;
            
          


              while ( userZahl != rnd) 
            {
                
                {
                if (userZahl < 1)
                {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Geben Sie eine gültige Zahl ein ;)");
                        Console.ForegroundColor = ConsoleColor.White;
                    userEingabe = Console.ReadLine();
                    userZahl = Int32.Parse(userEingabe);
                }
                if (userZahl > 100)
                {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Geben Sie eine gültige Zahl ein ;)");
                        Console.ForegroundColor = ConsoleColor.White;
                        userEingabe = Console.ReadLine();
                    userZahl = Int32.Parse(userEingabe);
                }
                if ( userZahl > rnd && userZahl < 100 && userZahl > 1)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Das ist falsch... Die Zahl ist zu gross!");
                    Console.ForegroundColor = ConsoleColor.White;
                    userEingabe = Console.ReadLine();
                    userZahl = Int32.Parse(userEingabe);
                    versuche++;
                    
                  
 
                
                
                }
                else
                {
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Das ist falsch... Die Zahl ist zu klein!");
                    Console.ForegroundColor = ConsoleColor.White;
                    userEingabe = Console.ReadLine();
                    userZahl = Int32.Parse(userEingabe);
                    versuche++;
                }
              }
                
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("!!!Sie haben die Zahl " + "--> " + userZahl + " <--"+ " erraten!!!");
            versuche++;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---Sie haben " + versuche + " Versuche gebraucht---");
                    Console.WriteLine("");

                    Console.WriteLine("Wollen Sie wissen wie gut Sie waren?");
                    Console.WriteLine("Wenn ja, geben Sie 'Ja' ein! Wenn nein, geben Sie 'Quit' ein...");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    string q = "quit";
                    if (Console.ReadLine().ToLower()== q)
                    {
                        Environment.Exit(0);
                    }
                    else if (versuche < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Sie sind ein -Naturtalent- !!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (versuche <= 7)
                        {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Sie sind gut!");
                        Console.ForegroundColor = ConsoleColor.White;
                        }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sie haben Verbesserungspotenzal...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Environment.Exit(0);
            

}
                catch (Exception)
            {
                    Console.Clear();
                    Console.WriteLine("Ungültige Eingabe...");                    
            }
             }
        }
    }
}



