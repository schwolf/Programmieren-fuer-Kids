using Microsoft.SmallBasic.Library;
using SmallBasicFun;
using System.Collections.Generic;

namespace SimpleSquare
{
    public class Schildkröte
    {
        /// <summary>
        /// Mit der Schildkröte kannst Du Linien und Formen malen indem Du Sie auf dem Bildschirm herumlaufen lässt.
        /// </summary>
        public Schildkröte()
        {
            Tortoise.Show();
        }

        /// <summary>
        /// Lässt die Schildkröte die angegebene Strecke (in Pixeln) nach vorne laufen.
        /// Negative Werte lassen die Schildkröte rückwärts laufen.
        /// Beispiel: Schildkröte.Laufen(50);
        /// </summary>
        public void Laufen(int Strecke)
        {
            Tortoise.Move(Strecke);
        }

        /// <summary>
        /// Dreht die Schildkröte im Uhrzeigersinn um den angegebenen Winkel (in Grad).
        /// Beispiel: Schildkröte.Drehen(90);
        /// </summary>
        public void Drehen(double Winkel)
        {
            Tortoise.Turn(Winkel);
        }

        /// <summary>
        /// Stellt die Farbe der Schildkrötenspur ein.
        /// Beispiel: Schildkröte.FarbeÄndern("rot");
        /// Du kannst auch angeben, dass du irgendeine Farbe möchtest: Schildkröte.FarbeÄndern("zufällig");
        /// </summary>
        public void FarbeÄndern(string Farbe)
        {
            Farbe = Farbe.ToLowerInvariant();

            var colors = new Dictionary<string, Primitive>
            {
                { "gelb", Colors.Yellow },
                {"blau", Colors.Blue },
                {"rot", Colors.Red },
                {"grün", Colors.Green },
                {"braun", Colors.Brown },
                {"grau", Colors.Gray }
            };

            var color = string.Equals(Farbe, "zufällig")
                ? Colors.GetRandomColor()
                : colors[Farbe];

            Tortoise.SetPenColor(color);
        }

        /// <summary>
        /// Stellt die Geschwindigkeit auf den angegebenen Wert ein.
        /// Die Geschwindigkeit geht von 1 bis 10.
        /// Beispiel: Schildkröte.GeschwindigkeitÄndern(7);
        /// </summary>
        public void GeschwindigkeitÄndern(int Geschwindigkeit)
        {
            Tortoise.SetSpeed(Geschwindigkeit);
        }

        /// <summary>
        /// Stellt die Breite der Schildkrötenspur ein.
        /// Beispiel: Schildkröte.ÄndereBreite(2);
        /// </summary>
        public void BreiteÄndern(int Breite)
        {
            Tortoise.SetPenWidth(Breite);
        }

        /// <summary>
        /// Setzt die Schildkröte an die angegebene Position.
        /// Beispiel: Schildkröte.Positioniere(0, 0);
        /// </summary>
        public void PositionÄndern(int x, int y)
        {
            Tortoise.SetPosition(x, y);
        }







    }
}
