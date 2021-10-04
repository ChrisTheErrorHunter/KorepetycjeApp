using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korepetycje
{
    public class Element
    {
        int id;
        string nazwa;
        public Element(int id, string nazwa)
        {
            this.id = id;
            this.nazwa = nazwa;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Nazwa
        {
            get
            {
                return nazwa;
            }
        }
    }
}
