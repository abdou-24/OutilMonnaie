using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Program
    {
        static void Main(string[] args)
        {//Variables

            Jump1:  Console.WriteLine("Bonjour et bienvenue sur cette application! Puis-je connaître votre prénom? " +
                "(Si vous avez deux prénoms veuillez les écrire s'il vous plaît, cela facilitera les présentations): ");
            string nom = Console.ReadLine();
           
            Console.WriteLine("Pourriez-vous me dire votre nom de famille? " +
                "(Comme mentionné en haut, n'hésitez pas à écrire tout les noms de famille que vous possédez) : ");
            string nomdefamille = Console.ReadLine();

            Console.WriteLine("Pour terminer, vous avez quelle âge? (seulement écrire le chiffre) : ");
            string âge = Console.ReadLine();

            Console.WriteLine("D'après les informations que vous avez écris, votre nom est " + nom + " " + nomdefamille + " et vous avez " + âge + " ans? " +
                "(Veuillez confirmer en écrivant Oui ou Non comme vous le voyez à l'écran) : ");
                string OuiNon = Console.ReadLine();
            int Oui = 0;
            int Non = 0;
            int answer = 0;
            if (answer = Oui)
            {


            }
            Console.ReadKey();



        }
    }
}
