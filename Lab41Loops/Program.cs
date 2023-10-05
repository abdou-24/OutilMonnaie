using System;
//Nom: Abdoulaye
//Date: 28 Septembre 2023
//Description: Pratique sur les boucles
namespace Lab41Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables globales
            int option = 0, num1 = 0;

            do
            {
                //Menu
                Console.WriteLine("\n\nEntrez 1 pour la boucle FOR");
                Console.WriteLine("Entrez 2 pour la boucle WHILE");
                Console.WriteLine("Entrez 3 pour la boucle ?");
                Console.WriteLine("Entrez 4 pour sortir de l'app");
                Console.WriteLine("Votre option: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: {
                            //ex1. for
                            Console.WriteLine("Entrez un numéro: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 < 0) { 
                                for ( int x = 0; x < 5; x++)
                                {
                                    Console.WriteLine("Plus petit que 0! ");
                                }
                            }
                            
                                if (num1 > 0)
                                {
                                    for (int x = 0; x < 7; x++)
                                    {
                                        Console.WriteLine("Plus grand que 0! ");
                                    }
                                }

                            
                            if (num1 == 0)
                            {
                                for (int x = 0; x < 5; x++)
                                {
                                    Console.WriteLine(" Nombre = 0! ");
                                }
                            }


                        } break;
                    case 2: {
                            //ex2. while
                            Console.WriteLine("Écrivez un numéro (à virgule): ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            while (num1 < 0)
                            {
                                for (int x = 0; x < 2; x++)
                                {
                                    Console.WriteLine("Nombre Négatif ! ");
                                }
                            }

                            
                            while (num1 > 0)
                            {
                                for (int x = 0; x < 3; x++)
                                {
                                    Console.WriteLine("Nombre positif !");
                                }
                            }

                            
                            while (num1 == 0)
                            {
                                for (int x = 0; x < 5; x++)
                                {
                                    Console.WriteLine("Nombre = 0! ");
                                }
                            }


                        } break;
                    case 3: {
                            //ex3. ?
                            Console.WriteLine("Entrez un nombre compris entre 1 et 18");

                            if (num1 < 18 & num1 > 1) ;

                            

                        } break;
                    case 4: { Console.WriteLine("On sort maintenant!"); } break;
                    default: { Console.WriteLine("Entrez 1 ou 2 ou 3 ou 4 "); } break;


                }


            } while (option != 4);

            Console.ReadKey();
        }
    }
}
