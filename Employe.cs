using System;

namespace VscExo
{
    public class Employe
   {
       //classe Employé caractérisée par les attributs : Matricule, Nom, Prénom, DateNaissance, DateEmbauche, Salaire.
       private int Matricule;
       private string Nom;
       private string Prenom;
       private DateTime DateNaissance;
       private DateTime DateEmbauche;
       private double Salaire;
       //les méthodes d’accès aux différents attributs de la classe.
       public int matricule
       {
           get { return Matricule;}
           set { Matricule = value;}
       }
       public string nom
       {
           get { return Nom;}
           set { Nom = value;}
       }
       public string prenom
       {
           get { return Prenom;}
           set { Prenom = value;}
       }
       public DateTime dateNaissance
       {
           get { return DateNaissance;}
           set { DateNaissance = value;}
       }
       public DateTime dateembauche
       {
           get { return DateEmbauche;}
           set { DateEmbauche = value;}
       }
       public double salaire
       {
           get { return Salaire;}
           set { Salaire = value;}
       }
       //un constructeur permettant d’initialiser les attributs de la méthode par des valeurs saisies par l’utilisateur.
       public Employe(int mat, string n, string pr, DateTime dn, DateTime de, double S)
       {
           this.Matricule = mat;
           this.Nom = n;
           this.Prenom = pr;
           this.DateNaissance = dn;
           this.DateEmbauche = de;
           this.Salaire = S;
       }
       //la méthode Age() qui retourne l’âge de l’employé.
       public int Age()
       {   
           int Age;
           Age = DateTime.Now.Year - DateNaissance.Year;
           if (DateTime.Now.Date < dateNaissance.AddYears(Age))
            Age--;
            return Age;
       }
       //la méthode Anciennete() qui retourne le nombre d’années d’ancienneté de l’employé.
       public int Anciennite()          
      {
        int Ancte;
        Ancte = DateTime.Now.Year - dateembauche.Year;
        if (dateembauche.AddYears(Ancte) > DateTime.Now.Date)
            Ancte--;
        return Ancte;
      } 
      //la méthode AugmentationDuSalaire( ) qui augmente le salaire de l’employé en prenant en considération l’ancienneté.
      public void AugmentationDuSalaire()
      {          
        if (Anciennite() < 5)
            Salaire += Salaire * 0.02;
        else if (Anciennite() < 10)
            Salaire += Salaire * 0.05;
        else 
            Salaire += Salaire * 0.1;
      }
      //la méthode AfficherEmployé() qui affiche les informations de l’employé comme suit :
      public void AfficherEmploye()
      {
          Console.Out.WriteLine("\n\nMatricule : "+ Matricule);
          //Le nom doit être affiché en majuscule. Pour le prénom, la première lettre doit être en majuscule, les autres en minuscule.
          Console.Out.WriteLine("\n\nNom Complet: "+ Nom.ToUpper() + " "+ Prenom.Substring(0,2).ToUpper() + Prenom.Substring(2).ToLower());
          Console.Out.WriteLine("\n\nAge : "+ Age());
          Console.Out.WriteLine("\n\nAncienneté : "+ Anciennite());
          Console.Out.WriteLine("\n\nSalaire : "+Salaire);  
              
      }
   }
}



