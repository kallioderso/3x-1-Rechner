using System.ComponentModel.Design;
using System.Thread

namespace Recher
{
    class DreiXPlusEins
    {
         static void Main(string[] args)
            {
                var EingabeZahl = Zahl;
                var Ergebnis = 0;
           
                Console.WriteLine("Wieviele Rechenzyklen von der Rechnung 3x+1 sollen Getätigt werden? (Bei ungeradem Ergbnis wird 3x+1 gerechnet, und bei Geradem Ergebnis wird : 2 gerechnet)");
                var Zyklen = Convert.ToInt32(Console.ReadLine());
           
                Console.WriteLine("In welcher Geschwindigkeit soll jeder Rechenzyklus ablaufen? (in Millisekunden)");
                var Speed = Convert.ToInt32(Console.ReadLine());
           
                Console.WriteLine("Mit welcher Zahl soll gerechnet werden?");
                var Zahl = Convert.ToInt64(Console.ReadLine());
           
                for (int i = 0; i < Zyklen; i++)
                {
                    if (Zahl == 1)
                    {
                        break;
                    }
                    Thread.Sleep(Speed);
                    if (Zahl %2 == 0 )
                    {
                        var NeueZahl = Zahl / 2;
                        Console.WriteLine(Zahl + " : 2 = " + NeueZahl);
                        Zahl = NeueZahl;
                    }
                    else
                    {
                        var NeueZahl = Zahl * 3 + 1;
                        Console.WriteLine(Zahl + " * 3 + 1 = " + NeueZahl);
                        Zahl = NeueZahl;
                    }
                }

                Console.WriteLine("Die Letzte Zahl im Zyklus von " + Zyklen + " Rechnungen der Zahl " + EingabeZahl + ", lautet " + Zahl);
            }
    }
   
}
