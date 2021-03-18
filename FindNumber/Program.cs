using System;

namespace FindNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool over = false;
            Random rand = new Random();
            int randValue = rand.Next(101);

            Console.WriteLine("Bienvenue dans le jeu du plus ou moins !");
            Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 inclus.");

            // tant que pas trouvé on continu...

            while (!over)
            {
                string inputString = Console.ReadLine();
                int inputNumber;

                // si la conversion à marchée
                if (int.TryParse(inputString, out inputNumber))
                {
                    // la valeur est hors cadre
                    if (inputNumber < 0 || inputNumber > 100)
                    {
                        Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 inclus.");
                    }

                    // si c'est le bon !
                    else if (inputNumber == randValue)
                    {
                        Console.WriteLine("Vous avez trouvé le nombre mystère BRAVO c'est bien : {0} !", randValue);
                        over = true;
                    }

                    // la valeur est trop grande
                    else if (inputNumber > randValue)
                    {
                        Console.WriteLine("Votre nombre est trop grand !");
                    }

                    // la valeur est trop petite
                    else if (inputNumber < randValue)
                    {
                        Console.WriteLine("Votre nombre est trop petit !");
                    }

                } // end for conversion ok

                // la conversion n'a pas réussie
                else
                {
                    Console.WriteLine("La conversion n'a pas réussie");
                    Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 inclus.");
                }
            } // end while

            Console.ReadLine();
        }
    }
}
