using MySql.Data.MySqlClient;
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
    public partial class ResetHaslo : Form
    {
        int id;
        public ResetHaslo()
        {
            InitializeComponent();
        }
        public ResetHaslo(string name, int id)
        {
            this.id = id;
            InitializeComponent();
            username.Text = name;
        }

        private bool Walidajca()
        {
            Walidator walidator = new Walidator();
            walidator.PoleTextoweWymagane(primepass, "Hasło", 2, 30);
            walidator.PoleTextoweWymagane(confirmpass, "imie", 2, 30);
            return walidator.WalidacjaPoprawna;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if(Walidajca())
            {
                if (primepass.Text == confirmpass.Text) //dodać try catch bo tak się nie godzi
                {
                    BazaDanych baza = new BazaDanych();

                    string SQL = "UPDATE korepetytor SET haslo = @haslo WHERE id = @id";


                    MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@haslo", primepass.Text);
                    baza.Polaczenie.Open();
                    command.ExecuteNonQuery();
                    baza.Polaczenie.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Podane hasła są różne od siebie");
                    return;
                }
            }
        }
    }
}
