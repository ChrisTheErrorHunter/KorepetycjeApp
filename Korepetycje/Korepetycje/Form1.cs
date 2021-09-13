using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Korepetycje
{
    public partial class Form1 : Form
    {
        Uzytkownik uzytkownik;
        public Form1()
        {
            InitializeComponent();
            
            Logowanie logowanie = new Logowanie();
            logowanie.ShowDialog(this);
            if (logowanie.Zalogowany)
            {
                uzytkownik = logowanie.Uzytkownik;
                this.btnKorepetytorzy.Enabled = uzytkownik.CzyAdministrator;
                UzupelnijDane(uzytkownik);
            }
            else
            {
                this.Close();
                //Application.Exit();
            }
        }

        private void UzupelnijDane(Uzytkownik uzytkownik)
        {
            textBoxLogin.Text = uzytkownik.Login;
            textBoxImie.Text = uzytkownik.Imie;
            textBoxNazwisko.Text = uzytkownik.Nazwisko;
            checkBoxAdministrator.Checked = uzytkownik.CzyAdministrator;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentsView sl = new StudentsView();
            sl.ShowDialog();
            /*string connetionString = null;
            MySqlConnection conn;
            connetionString = "server=localhost;user id=root;database=warsztat;SSL Mode=None";
            conn = new MySqlConnection(connetionString);

            string SQL_Query = "SELECT * FROM mechanik";

            

            try
            {
                MySqlCommand command = new MySqlCommand(SQL_Query, conn);
                MySqlDataReader dataReader;
                conn.Open();
                dataReader = command.ExecuteReader();
                dataReader.Read();
                label1.Text = dataReader.GetString(4)+"";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }*/
        }

        private void btnKorepetytorzy_Click(object sender, EventArgs e)
        {
            ListaKorepetytorow lista = new ListaKorepetytorow();
            lista.ShowDialog(this);
        }

        private void btnKlasy_Click(object sender, EventArgs e)
        {
            ListaKlas lista = new ListaKlas();
            lista.ShowDialog(this);
        }

        private void btnPrzedmioty_Click(object sender, EventArgs e)
        {
            ListaPrzedmiotow lista = new ListaPrzedmiotow();
            lista.ShowDialog(this);
        }

        private void btnLekcje_Click(object sender, EventArgs e)
        {
            ListaLekcji lista = new ListaLekcji(uzytkownik);
            lista.ShowDialog(this);
        }

        private void btn_konta_Click(object sender, EventArgs e)
        {
            ListaRachunkow lista = new ListaRachunkow(uzytkownik);
            lista.ShowDialog();
        }
    }
}
