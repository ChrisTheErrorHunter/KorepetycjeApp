using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korepetycje
{
    public partial class Potwierdzenie : Form
    {
        bool potwierdzono = false;
        public bool Potwierdzono
        {
            get
            {
                return potwierdzono;
            }
        }
        public Potwierdzenie()
        {
            InitializeComponent();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            potwierdzono = true;
            this.Close();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
