using System;

namespace RekenmachineLibrary
{
    public class Berekening
    {
        public static double MaakBerekening(double getal1,double getal2,char operatie)
        {
            double resultaat;
            switch (operatie)
            {
                case '+':
                    resultaat = getal1 + getal2;
                    break;
                case '-':
                    resultaat = getal1 - getal2;
                    break;
                case '*':
                    resultaat = getal1 * getal2;
                    break;
                case '/':
                    resultaat = getal1 / getal2;
                    break;
                case '^':
                    resultaat = Math.Pow(getal1, getal2);
                    break;
                default:
                    resultaat = 0;
                    break;
            }
            return resultaat;
        }
    }
}
