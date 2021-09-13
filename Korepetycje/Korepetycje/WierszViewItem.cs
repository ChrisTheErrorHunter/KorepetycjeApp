using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korepetycje
{
    class WierszViewItem : ListViewItem
    {
        int id;
        public WierszViewItem(int id,string name) : base(name)
        {
            this.id = id;
  
        }

        public int Id
        {
            get
            {
                return id;
            }
            /*set
            {
                id = value;
            }*/

        }
    }
}
