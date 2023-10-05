using System;
using System.Xml.Schema;

namespace labo_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Ex 5
            //Variables
            int num1;
        Jump1: Console.WriteLine("Entrez un nombre entre 1 et 15: ");
                 try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex3)
            {
                Console.WriteLine(ex3.Message);
                goto Jump1;
            }
            while (num1 < 1 || num1 > 18)
            {
                goto Jump1;
            }
           // int i = 0;
            int total = 0;
            for (int i = num1; i > 0; i--) 
            {     
                total = total + i;
            }

            Console.WriteLine("Le résultat est: " + total);
            string y;
            string Y;
            string answer;
            
                Console.WriteLine("Entrez la lettre " +y+ " ou " +Y+ " pour  continuer  ,  ou toute autre chose pour  quitter: " + answer + "");

            
            while (("continuer" == y) || ("continuer" == Y));

            if ( answer == y )
            {

                goto Jump1;

            }
            else
            {
                Console.WriteLine("Merci d'utliser l'application !");
            }



              Console.ReadKey();
        }
    }
}
