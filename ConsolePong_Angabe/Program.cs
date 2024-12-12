using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePong
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // PONG 01 - Aufgabenstellung 1/2

            /*Vector2D v1 = new Vector2D(3, 4);
            Vector2D v2 = new Vector2D(-2, -5);
            Vector2D v3 = v1 + v2;
            Console.WriteLine($"{v1} + {v2} = {v3}");*/

            // testen der Vector 2D Funktionalität mittels Zugriff auf Vriablen
            // Komplexität: simpel
            // Aufwand: moderat

            // testen der Vector 2D Funktionalität mittels toString überladung
            // Komplexität: mittel
            // Aufwand: gering

            // PONG 01 - Aufgabenstellung 2/2

            // Beim Testen der Window Size (Vector2D) out of bound exception bei zu großen Werten möglich
            // Beim Auffordern des Konsolenfenster und Farben testens auf Eingabe im Draw Methodenaufruf hinweisen

            // Field.Draw(new Vector2D(100, 50), ConsoleColor.Yellow, ConsoleColor.Black);

            // testen der Field Draw methode durch verändern der Eingabeparameter
            // Komplexität: simpel
            // Aufwand: gering


            // PONG 02 - Aufgabenstellung 1/1

            //new Game().Run();

            // Aufwand: moderat (einiges abzuschreiben)
            // Komplexität: gering (nichts eigenständig zu programmieren,
            // eigentlich nur testen über Parameter + einfügen von Blöcken an richtigen Codestellen)


            // PONG 03 - Aufgabenstellung 1/1

            // new Game().Run();

            // Aufwand: hoch (viel abzuschreiben)
            // Komplexität: gering (nichts eigenständig zu programmieren,
            // eigentlich nur testen über Parameter + einfügen von Blöcken an richtigen Codestellen)


            // PONG 04 - Aufgabenstellung 1/1

            new Game().Run();

            // Aufwand: hoch (viel abzuschreiben)
            // Komplexität: gering (spiegelverkehrte Wiederholung von
            // Programmierung mit Hilfestellung)


            // PONG 05 - Aufgabenstellung 1/1

            // nicht vergessen in Game die print paddleRight Funktion einzufügen
            //new Game().Run();

            // Aufwand: moderat (einiges abzuschreiben)
            // Komplexität: mittel (spiegelverkehrte Wiederholung von
            // Programmierung ohne Hilfestellung)


            // PONG 06 - Aufgabenstellung 1/1

            // Aufwand: hoch (einiges abzuschreiben + komplex)
            // Komplexität: hoch (spiegelverkehrte Wiederholung von komplexer
            // Programmierung + nötiger Mathematik ohne Hilfestellung)

        }
    }
}
