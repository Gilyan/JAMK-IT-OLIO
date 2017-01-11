/* **************************************
Lottoharjoitus

Luotu 10.1.2017

Toiminta: Lottosovellus, jossa arvotaan 7 satunnaista numeroa 40 numerosta (1-40).
Käyttäjältä kysytään, kuinka monta lottoriviä halutaan arpoa.
Samalle riville ei saa tulla jo arvottuja numeroita.

Minttu Mäkäläinen K8517 @ JAMK
Viety GitHubiin 11.1.2017
************************************** */

using System;
using System.Linq;

namespace JAMK.IT                           // Määrittelee tämän sovelluksen nimiavaruuden
{
    public class Lottokone                  // Määrittelee sovelluksen pääluokan
    {
        public static void DrawLotto()
        {
            int numero = 0, i = 0, e = 1;   // Esitellään ja alustetaan muuttujia
            int rivit;

            int[] lotto = new int[7];       // Lottonumeroille taulukko = 7 paikkaa

            Random rand = new Random();

            Console.Write("Kuinka monta lottoriviä arvotaan? ");
            rivit = int.Parse(Console.ReadLine());  // Otetaan annettu lottorivimäärä talteen

            while (e <= rivit)                      // Tehdään niin monta riviä, kuin on haluttu
            {
                while (i < lotto.Length)            // Pyöritetään niin kauan kuin taulukkoon vielä mahtuu uusia numeroita
                {
                    numero = rand.Next(1, 40);      // Arvotaan satunnaislukugeneraattorin avulla numero väliltä 1-40

                    if (!lotto.Contains(numero))    // Jos arvottu numero ei vielä löydy taulukosta
                    {
                        lotto[i] = numero;          // Tallennetaan arvottu numero taulukkoon
                        i++;
                    }
                }

                Array.Sort(lotto);                  // Lajittelee numerot suuruusjärjestykseen

                Console.Write("\nRivi " + e + ": ");    // \n = rivinvaihto

                for (int r = 0; r < lotto.Length; r++)  // Tulostaa arvotun rivin
                {
                    Console.Write(lotto[r] + ", ");
                }

                lotto = new int[7];                 // Alustetaan taulukko uudelleen

                e++;
                i = 0;
            }

            Console.ReadKey();
        }
    }
}

