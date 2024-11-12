using System;
using System.Collections.Generic;
using System.Text;

namespace GRUPPENPROJEKT
{
    public class Sparkonto : Konto
    {
        public Sparkonto(string kontonummer, string inhaber) : base(kontonummer, inhaber)
        {
            // Hier können spezifische Eigenschaften für Sparkonto hinzugefügt werden.
        }


        public void ZinsenGutschreiben()
        {
            // Berechnung der Zinsen (1% des aktuellen Kontostands)
            decimal zinsen = Kontostand * 0.01m; // 1% Zinsen
            //Konto.Einzahlen(zinsen); // Zinsen dem Kontostand hinzufügen
        }


    }
}
