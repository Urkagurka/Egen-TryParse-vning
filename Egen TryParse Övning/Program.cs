using System;

namespace TryParse_uppgift
{
    class Program
    {
        static void Main(string[] args)
        {


            int resultat;
            if (!TryParse(Console.ReadLine(), out resultat))
                Console.WriteLine("Du får bara ange siffror");
            else
            {
                Console.WriteLine("Resultatet är " + resultat );
            }
        }
        public static bool TryParse(string s, out int resultat)
        {
            int p = 1;
            int tal = 0;
            if (s.Length == 0)
            {
                resultat = 0;
                return false;
            }
            for (int i = s.Length-1; i >= 0; i-- )
            {
                char c = s[i];
                int v = 0;
                switch (c)
                {
                    case '0':
                        v = 0;
                        break;
                    case '1':
                        v = 1;
                        break;
                    case '2':
                        v= 2;
                        break;
                    case '3':
                        v = 3;
                        break;
                    case '4':
                        v = 4;
                        break;
                    case '5':
                        v = 5;
                        break;
                    case '6':
                        v = 6;
                        break;
                    case '7':
                        v = 7;
                        break;
                    case '8':
                        v = 8;
                        break;
                    case '9':
                        v = 9;
                        break;
                    default:
                        resultat = 0;
                        return false;
                }
                
                tal = tal + (v*p);
                p = p * 10;

            }
            resultat = tal;
            return true;
        }
    }
}