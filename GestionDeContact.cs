using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoListeContact
{
   public class GestionDeContact : Contact
    {
        List<Contact> contacts = new List<Contact>();
        private int id = 1;
        public void AddContact(string Name, string LastName, string PhoneNumber, string Email)
        {
            Contact newContact = new Contact()
            {
                Id = id++
            };

            Console.WriteLine("Entrez le Nom:");
            newContact.Name = Console.ReadLine();

            Console.WriteLine("Entrez le Prénom:");
            newContact.LastName = Console.ReadLine();

            Console.WriteLine("Entrez l'Email");
            newContact.Email = Console.ReadLine();

            Console.WriteLine("Téléphone");
            newContact.PhoneNumber = Console.ReadLine();
        }

        public void UpdateContact(int id, string name, string LastName, string PhoneNumber, string Email) 
        {

        }

        
    }
}
