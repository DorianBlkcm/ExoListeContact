using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Security.Principal;

namespace ExoListeContact
{
    public class GestionDeContact : Contact
    {
        List<Contact> contacts = new List<Contact>();
        private int id = 1;

        //AJOUTER D'UN CONTACT PAR L'UTILISATEUR A PARTIR DE LA CONSOLE
        public void AddContact()
        {
            Contact newContact = new Contact()
            {
                Id = id++
            };

            Console.WriteLine("Entrez le Nom:");
            newContact.Name = Console.ReadLine();
            Console.WriteLine("Le nom à était ajouté avec succées");

            Console.WriteLine("Entrez le Prénom:");
            newContact.LastName = Console.ReadLine();

            Console.WriteLine("Entrez l'Email");
            newContact.Email = Console.ReadLine();

            Console.WriteLine("Téléphone");
            newContact.PhoneNumber = Console.ReadLine();

            contacts.Add(newContact);

            Console.WriteLine("Contact créer, l'id est : "+ id);

        }

        public void UpdateContact()
        {

            Console.WriteLine("Entrez l'id de l'utilisateur que vous voulez modifier : ");
            int idUser = int.Parse(Console.ReadLine());


            Contact contact = contacts.Find(user => user.Id == idUser);
            if (contact != null)
            {
                Console.WriteLine("Entrez le nouveau nom de votre contact");
                string Name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Name))
                {
                    contact.Name = Name;
                }

                Console.WriteLine("Entrez le nouveau Prénom de votre contact");
                string LastName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    contact.LastName = LastName;

                }

                Console.WriteLine("Entrez le nouveau Prénom de votre contact");
                PhoneNumber = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(PhoneNumber))
                {
                    contact.PhoneNumber = PhoneNumber;

                }

                Console.WriteLine("Entrez le nouveau Prénom de votre contact");
                string Email = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Email))
                {
                    contact.Email = Email;

                }

                Console.WriteLine("Contact modifié avec succées");
            }

            else
            {
                Console.WriteLine("Contact non trouvé !");
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Entrez l'id du contact que vous voulez suprimer");
            int id = int.Parse(Console.ReadLine());

            Contact contact = contacts.Find(user => user.Id == id);
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Le contact avec l'id : " + id + "à bien était suprimer !");
            }
            else
            {
                Console.WriteLine("Id non trouver !");
            }

        }

    }
   
}
        
    

