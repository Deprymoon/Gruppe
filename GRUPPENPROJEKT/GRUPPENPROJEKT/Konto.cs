using System;
using System.Collections.Generic;
using System.Text;

namespace GRUPPENPROJEKT
{

    public class Konto
    {
        public string Kontonummer { get; private set; }
        public decimal Kontostand { get; private set; }
        public string Inhaber { get; private set; }

        public Konto(string kontonummer, string inhaber)
        {
            Kontonummer = kontonummer;
            Inhaber = inhaber;
            Kontostand = 0; // Anfangskontostand ist 0
        }

        public void Einzahlen(decimal betrag)
        {
            // Überprüfen, ob der Betrag positiv ist
            if (betrag > 0)
            {
                Kontostand += betrag; // Betrag zum Kontostand hinzufügen
            }
        }

        public void Abheben(decimal betrag)
        {
            // Überprüfen, ob der Betrag positiv ist und ob genügend Guthaben vorhanden ist
            if (betrag > 0 && betrag <= Kontostand)
            {
                Kontostand -= betrag; // Betrag vom Kontostand abziehen
            }
        }

        public decimal GetKontostand()
        {
            return Kontostand; // Aktuellen Kontostand zurückgeben
        }
    }
}



    

