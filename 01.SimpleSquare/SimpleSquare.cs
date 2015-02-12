using LearnKidsProgramming._01.SimpleSquare;
using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquare
	{
		public static void Main()
		{
			// wir brauchen eine neue schildkröte
			Schildkröte Monti = new Schildkröte(); 
			
			Monti.GeschwindigkeitÄndern(1000);
			
//			var Zahl = 0;
//			var Seiten = 100;
//			
//			while (Zahl < Seiten)
//			{
//				Monti.BreiteÄndern(3);
//				Monti.FarbeÄndern("grün");
//				Monti.Laufen(50);
//				Monti.Drehen(360.0 / Seiten);
//				Zahl = Zahl + 1;
//			}
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			// einfach
			var zahl = 0;
			
			AbfrageBox box = new AbfrageBox();
			
			var seiten = box.Anzeigen("Wie viele Seiten?");
			
			while (zahl < seiten)
			{
				zahl = zahl + 1;
				Monti.BreiteÄndern(zahl * 2);
				Monti.FarbeÄndern("zufällig");
				Monti.Laufen(zahl * 3);
				Monti.Drehen(3 * 360.0 / seiten);
			}
			
			
			
			// cool
//			var zahl = 0;
//			AbfrageBox box = new AbfrageBox();
//			
//			var seiten = box.Anzeigen("Wie viele Seiten?");
//			
//			
//			while (zahl  < seiten)
//			{
//				Monti.BreiteÄndern(zahl + 1);
//				Monti.FarbeÄndern("zufällig");
//				Monti.Laufen(zahl * 3);
//				Monti.Drehen(360.0 * 3 / seiten);
//				zahl = zahl + 1;
//			}
			
			
			
		}
	}
}