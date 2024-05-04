using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_en_CSharp
{
    // .pakistan => Discord
    public class Objet //Ceci est une classe, elle permet d'englober des paramètres, des fonctions et d'autre données qui sont répertoriés dans la classe
    {
        private string nom; // propriété privé
        private int age;
        private bool femme;

        public Objet (string nom, int age, bool femme) // Constructeur
        {
            this.nom = nom;
            this.age = age;
            this.femme = femme;
        }

        public string Sexe()
        {
            if (femme == true)
                return "Femme";
            else
                return "Homme";
        }

        public int GetAge()
        { return this.age; }

        public string Nom
        { get { return this.nom; } } // Propriété public

        public static int ValeureUn()
        { return 1; }

        //Exemple 1
        /*
         * Ceci est une fonction dite void, elle ne retourne aucun type
         * elle s'appelle PointEntrée
         * Et elle écrit un message dans la console
         * Elle peut être appelé uniquement depuis une instance d'objet car absence du mot clés static
         */
        public void PointEntrée() 
        {
            Console.WriteLine($"Nom : {this.nom}, Age : {this.age}, Sexe : {this.Sexe()}");
        }
    }
}
