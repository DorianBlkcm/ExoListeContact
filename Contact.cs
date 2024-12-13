using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoListeContact
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"ID: {Id}, Nom: {Name}, Prénom: {LastName}, Téléphone: {PhoneNumber}, Email: {Email}";
        }
    }
}
