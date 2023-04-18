using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitJourney
{
    public class Client
    {
        private string name;
        private string surname;
        private bool isAdmin;

        public Client(string pname, string pSurname)
        {
            this.Name = pname;
            this.Surname = pSurname;

        }
        public Client(string name, string surname, bool isAdmin)
        {
            this.isAdmin = isAdmin;
            Name = name;
            Surname = surname;

            

        }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
    }
}
