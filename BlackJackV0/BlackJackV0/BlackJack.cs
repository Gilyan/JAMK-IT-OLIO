/* **************************************
BlackJack-harjoitus

Luotu 11.1.2017

Toiminta: Käyttäjältä kysytään numeroa väliltä 1-21. Annettua numeroa verrataan
koneen arpomaan lukuun (arpoo väliltä 10-21), mikäli käyttäjän luku on suurempi, 
käyttäjä voittaa. Pienemmällä luvulla käyttäjä häviää.

Mikäli syötetään 'x' tai 'exit', ohjelma lopetetaan.

Minttu Mäkäläinen K8517 @ JAMK
Viety GitHubiin 11.1.2017
************************************** */

using System;
using System.Linq;

namespace JAMK.IT
{
  class BlackJack
  {
    static void Main()
        {
            // Lottokone.DrawLotto();           // Lottokone
            Uhkapeli();                         // BlackJack
        }

        static void Uhkapeli()
            {
                int myNumber;
                string muuttuja;
                int theirNumber;

                Random rand = new Random();

                System.Console.WriteLine("*** BlackJack! ***");

                do
                {
                    System.Console.Write("Can you beat my number? Enter any number between 1-21: ");

                    muuttuja = System.Console.ReadLine();                       // reading input

                    if (muuttuja == "x" || muuttuja == "exit")
                    {
                        break;
                    }

                try
                {
                    theirNumber = Convert.ToInt32(muuttuja);

                    if (theirNumber < 1 || theirNumber > 21)            // comparing that given number is valid
                    {
                        Console.WriteLine("The given number is out of limits, try again. (1-21)");
                    }

                    else
                    {
                        myNumber = rand.Next(10, 21);                       // random number between 10-21
                        Console.WriteLine("My number is " + myNumber + ", and your number is " + theirNumber + ".");

                        if (theirNumber >= myNumber && theirNumber <= 21)   //comparing
                        {
                            System.Console.WriteLine("You win.");
                        }
                        else
                        {
                            System.Console.WriteLine("You lose.");
                        }
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter any number between 1-21. Enter 'x' or 'exit' to quit.");
                }

                

                /*if (muuttuja.GetType() == typeof(int))
                    {
                        theirNumber = Convert.ToInt32(muuttuja);            // converting to int

                        if (theirNumber < 1 || theirNumber > 21)            // comparing that given number is valid
                        {
                            Console.WriteLine("The given number is out of limits, try again.");
                        }

                        myNumber = rand.Next(10, 21);                       // random number between 10-21
                        Console.WriteLine("My number is " + myNumber + ", and your number is " + theirNumber + ".");

                        if (theirNumber >= myNumber && theirNumber <= 21)   //comparing
                        {
                            System.Console.WriteLine("You win.");
                        }
                        else
                        {
                            System.Console.WriteLine("You lose.");
                        }
                    }*/

            } while (true);
            
        }
  }
}