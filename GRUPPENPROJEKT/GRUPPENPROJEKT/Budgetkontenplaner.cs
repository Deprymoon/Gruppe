using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GRUPPENPROJEKT
{
    class Budgetkontenplaner
    {
        static void Main(string[] args)
        {
            // Erstellen eines Girokontos
            Console.WriteLine("Geben Sie die Kontonummer für das Girokonto ein:");
            string giroKontoNummer = Console.ReadLine();
            Console.WriteLine("Geben Sie den Inhaber für das Girokonto ein:");
            string giroInhaber = Console.ReadLine();
            decimal giroKontostand = 0;

            // Erstellen eines Sparkontos
            Console.WriteLine("Geben Sie die Kontonummer für das Sparkonto ein:");
            string sparKontoNummer = Console.ReadLine();
            Console.WriteLine("Geben Sie den Inhaber für das Sparkonto ein:");
            string sparInhaber = Console.ReadLine();
            decimal sparKontostand = 0;

            // Interaktion mit dem Benutzer
            while (true)
            {
                Console.Clear(); // Bildschirm löschen
                Console.WriteLine("Willkommen im Bankensystem!");
                Console.WriteLine("\nWählen Sie eine Option:");
                Console.WriteLine("1. Einzahlung auf Girokonto");
                Console.WriteLine("2. Abhebung vom Girokonto");
                Console.WriteLine("3. Einzahlung auf Sparkonto");
                Console.WriteLine("4. Abhebung vom Sparkonto");
                Console.WriteLine("5. Zinsen gutschreiben auf Sparkonto (1%)");
                Console.WriteLine("6. Kontostand anzeigen");
                Console.WriteLine("7. Beenden");
                Console.Write("Ihre Wahl: ");
                string wahl = Console.ReadLine();

                switch (wahl)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Geben Sie den Betrag für die Einzahlung auf das Girokonto ein: ");
                        decimal einzahlungsBetragGiro = Convert.ToDecimal(Console.ReadLine());
                        giroKontostand = Konto.Einzahlen(einzahlungsBetragGiro, giroKontostand);
                        Thread.Sleep(2000); // 2 Sekunden warten
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Geben Sie den Betrag für die Abhebung vom Girokonto ein: ");
                        decimal abhebungsBetragGiro = Convert.ToDecimal(Console.ReadLine());
                        giroKontostand = Konto.Abheben(abhebungsBetragGiro, giroKontostand);
                        Thread.Sleep(2000); // 2 Sekunden warten
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("Geben Sie den Betrag für die Einzahlung auf das Sparkonto ein: ");
                        decimal einzahlungsBetragSpar = Convert.ToDecimal(Console.ReadLine());
                        sparKontostand = Konto.Einzahlen(einzahlungsBetragSpar, sparKontostand);
                        Thread.Sleep(2000); // 2 Sekunden warten
                        break;

                    case "4":
                        Console.Clear();
                        Console.Write("Geben Sie den Betrag für die Abhebung vom Sparkonto ein: ");
                        decimal abhebungsBetragSpar = Convert.ToDecimal(Console.ReadLine());
                        sparKontostand = Konto.Abheben(abhebungsBetragSpar, sparKontostand);
                        Thread.Sleep(2000); // 2 Sekunden warten
                        break;

                    case "5":
                        Console.Clear();
                        sparKontostand *= 1.01m; // Zinsen gutschreiben
                        Console.WriteLine($"Zinsen wurden gutschrieben. Neuer Kontostand: {sparKontostand:C}");
                        Thread.Sleep(2000); // 2 Sekunden warten
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine($"Girokonto Kontostand: {giroKontostand:C}");
                        Console.WriteLine($"Sparkonto Kontostand: {sparKontostand:C}");
                        Thread.Sleep(2000); // 2 Sekunden warten
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Programm wird beendet.");
                        return; // Beendet die Anwendung

                    default:
                        Console.Clear();
                        Console.WriteLine("Ungültige Auswahl. Bitte versuchen Sie es erneut.");
                        Thread.Sleep(2000); // 2 Sekunden warten
                        break;
                }
            }
        }
    }
}

