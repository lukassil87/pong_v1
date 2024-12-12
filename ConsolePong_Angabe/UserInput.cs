﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsolePong
{
    internal class UserInput
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Int32 vKey);

        
        static public bool GetKeyState(Paddle paddleLeft, Paddle paddleRight)
        {
            
            if (Console.KeyAvailable)
            {
                /* T1-Klasse 02 - Aufgabe_1
                 * 
                 * Ändere die gegebene if-Bedingung, um mit einer passendne Taste das linke Paddle nach oben bewegen zu können
                 * 
                 * Erweitere die Methode anschließend um drei weitere if-Bediungen, die die folgenden Funktionen erüllen sollen:
                 * - linkes Paddle nach unten bewegen
                 * - rechtes Paddle nach oben bewegen
                 * - rechtes Paddle nach unten bewegen
                */

                if (GetAsyncKeyState((int)ConsoleKey.X) != 0)
                    paddleLeft.Update("direction");

                // TODO A_1

                /* T1-Klasse 02 - Aufgabe_2
                 * 
                 * Füge eine weitere Abfrage ein, die den Status der Escape-Taste bestimmt.
                 * Dieser Block soll false zurückgeben, sollte die Taste gedrückt werden.
                */

                // TODO A_2

            }
            return true;
        }
    }
}
