using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korepetycje
{
    public class Uzytkownik
    {
        private int id;
       
        public Uzytkownik(int id)
        {
            this.id = id;
        }

        public int Id 
        { 
            get
            {
                return id;
            }
        }

        public string Login { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public bool CzyAdministrator { get; set; }

    }
}
