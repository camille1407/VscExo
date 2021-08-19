using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace VscExo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Mat;           
            string Nom, Prenom;
            DateTime dn, de;
            double Salaire;

            Console.Out.WriteLine("\nMatricule : ");
            Mat = int.Parse(Console.In.ReadLine());
            Console.Out.WriteLine("\nNom : ");
            Nom = Console.In.ReadLine();
            Console.Out.WriteLine("\nPrenom : ");
            Prenom = Console.In.ReadLine();
            Console.Out.WriteLine("\nDate de naissance(jj/mm/aaaa) : ");
            dn = DateTime.Parse(Console.In.ReadLine());
            Console.Out.WriteLine("\nDate d'embauche(jj/mm/aaaa) : ");
            de = DateTime.Parse(Console.In.ReadLine());
            Console.Out.WriteLine("\nSalire : ");
            Salaire = double.Parse(Console.In.ReadLine());
           
            System.Out.WriteLine("*************************************");

            Employe ep = new Employe(Mat, Nom, Prenom, dn, de, Salaire);
            ep.AfficherEmploye();

            System.Out.WriteLine("*************************************");
            
            Console.Out.WriteLine("\nAprès l'Augmentationde de salaire");
            ep.AugmentationDuSalaire();
            ep.AfficherEmploye();
        }
    }
}

