using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmallBasicFun;

namespace LearnKidsProgramming._01.SimpleSquare
{
    public class AbfrageBox
    {
        /// <summary>
        /// Eine Abfragebox erscheint mit der Frage.
        /// Beispiel: AbfrageBox.Anzeigen("Wie alt bist Du?")
        /// </summary>
        public int Anzeigen(string Frage)
        {
            return MessageBox.AskForInput(Frage);
        }
    }
}
