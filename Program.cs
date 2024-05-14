using ExoListeContact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {

       GestionDeContact Gestion = new GestionDeContact();

        while (true)
        {
            Console.WriteLine("1.Ajouter un contact :");
            Console.WriteLine("2.Modifier un contact");
            Console.WriteLine("3.Suprimer un contact");
            Console.WriteLine("4.Quitter");

            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    Console.WriteLine("Ajouter un nouveau contact !");
                    Gestion.AddContact();
                    break;
                case "2":
                    Console.WriteLine("Modifier un contact !");
                    Gestion.UpdateContact();
                    break;
                case "3":
                    Console.WriteLine("Suprimer un contact");
                    Gestion.DeleteContact();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Choix invalide");
                    break;

            }
        }

    }

}