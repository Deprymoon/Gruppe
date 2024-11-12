using System;
using System.Collections.Generic;
using System.Text;

namespace GRUPPENPROJEKT
{

    public class Konto
    {
        public string Kontonummer { get; private set; }
        public static decimal Kontostand { get; set;}
        public string Inhaber { get; private set; }

        public Konto(string kontonummer, string inhaber)
        {
            Kontonummer = kontonummer;
            Inhaber = inhaber;
            Kontostand = 0; // Anfangskontostand ist 0
        }
        public static decimal Einzahlen(decimal betrag, decimal Kontostand)
        {
            // Überprüfen, ob der Betrag positiv ist
            if (betrag > 0)
            {
                Kontostand += betrag; // Betrag zum Kontostand hinzufügen
                Console.WriteLine("Einzahlung von "+ betrag +" erfolgreich. Neuer Kontostand: "+Kontostand+ "");
            }
            else
            {
                Console.WriteLine("Der Betrag muss positiv sein."); //Betrag kann nicht hinzugefügt werden
            }
            return Kontostand;
        }

        public static decimal Abheben(decimal betrag, decimal Kontostand)
        {
            // Überprüfen, ob der Betrag positiv ist und ob genügend Guthaben vorhanden ist
            if (betrag > 0 && betrag <= Kontostand)
            {
                Kontostand -= betrag; // Betrag vom Kontostand abziehen
                Console.WriteLine("Abhebung von " + betrag + " erfolgreich. Neuer Kontostand: " + Kontostand + "");
            }
            else
            {
                if (betrag < 0)
                {
                    Console.WriteLine("Der Betrag muss positiv sein.");
                }
                else
                {
                    Console.WriteLine("Abhebung nicht möglich. Überprüfen Sie den Betrag.");
                }
            }
            return Kontostand;
        }
        public decimal GetKontostand()
        {
            return Kontostand; // Aktuellen Kontostand zurückgeben
        }
    }
}
