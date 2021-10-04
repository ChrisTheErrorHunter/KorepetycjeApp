using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korepetycje
{
    class Walidator
    {
        bool walidacjaPoprawna;
        public Walidator()
        {
            walidacjaPoprawna = true;
        }

        public void PoleTextoweWymagane(TextBox textbox, string nazwa, int min, int max)
        {
            if (textbox.Text.Length == 0)
            {
                MessageBox.Show(string.Format("Pole '{0}' musi być uzupelnione",nazwa));
                walidacjaPoprawna =  false;
                return;
            }
            if (textbox.Text.Length < min)
            {
                MessageBox.Show(string.Format("Pole '{0}' musi mieć minimum {1} znaków", nazwa, min));
                walidacjaPoprawna = false;
                return;
            }
            if (textbox.Text.Length > max)
            {
                MessageBox.Show(string.Format("Pole '{0}' może mieć maksymalnie {1} znaków", nazwa, max));
                walidacjaPoprawna = false;
                return;
            }
        }

        public bool WalidacjaPoprawna
        {
            get
            {
                return walidacjaPoprawna;
            }
        }

    }
}
