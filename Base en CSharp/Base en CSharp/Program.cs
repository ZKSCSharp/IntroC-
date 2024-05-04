using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_en_CSharp
{
    // .pakistan => Discord

    internal class Program
    {
        private static Objet obj;
        private static Objet obj2;
        private static List<Objet> liste;

        static void Main(string[] args)
        {
            liste = new List<Objet>();
            obj = new Objet("Lisa", 22, true);
            obj2 = new Objet("Théo", 22, false);

            liste.Add(obj);
            liste.Add(obj2);

            for (int i = 0; i < liste.Count; i++) // Boucle
            {
                liste[i].PointEntrée();
            }

            Console.WriteLine(Objet.ValeureUn());
            Console.ReadLine();
        }

        /*
         * Coffre fort
         * 
         * Créer une liste d'utilisateur qui auront :
         *      - un nom
         *      - un age
         *      - une adresse mail
         *      - mot de passe
         *      - un sexe
         *      - nationalité
         * 
         * Si on rentre mail et mot de passe
         * on affiche le nom, l'age, la nationalité, et le sexe
         */
    }
}
