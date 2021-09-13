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
    public partial class OknoKorepetytor : Form
    {
        int id;
        bool sukces;
        bool trybEdycji;
        bool resetHasla;

        public OknoKorepetytor()
        {
            InitializeComponent();
            id = -1;
            sukces = false;
            trybEdycji = false;
            resetHasla = false;
            this.btnPotwierdz.Text = "Dodaj";
            btnResetujHaslo.Enabled = false;
            
        }

        public OknoKorepetytor(int id)
        {
            InitializeComponent();
            this.id = id;
            sukces = false;
            trybEdycji = true;
            resetHasla = false;
            this.btnPotwierdz.Text = "OK";
            WczytajDane();

        }

        private void WczytajDane()
        {
            try
            {
                BazaDanych baza = new BazaDanych();

                string SQL = "SELECT login, imie, nazwisko, czyAdministrator FROM korepetytor WHERE id = @id;";

                MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                command.Parameters.AddWithValue("@id", id);


                baza.Polaczenie.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    textBoxLogin.Text = BazaDanych.CzytajString(dataReader, 0);
                    textBoxImie.Text = BazaDanych.CzytajString(dataReader, 1);
                    textBoxNazwisko.Text = BazaDanych.CzytajString(dataReader, 2);
                    checkBoxCzyAdministrator.Checked = BazaDanych.CzytajBool(dataReader, 3);
                }

                baza.Polaczenie.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystapił nieprzewidziany problem");
                sukces = false;
            }
        }

        private bool Walidajca()
        {
            Walidator walidator = new Walidator();
            walidator.PoleTextoweWymagane(textBoxLogin, "login", 5, 30);
            walidator.PoleTextoweWymagane(textBoxImie, "imie", 2, 30);
            walidator.PoleTextoweWymagane(textBoxNazwisko, "nazwisko", 2, 30);

            return walidator.WalidacjaPoprawna;
        }
        private void Dodaj()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "INSERT INTO korepetytor (login, haslo, imie, nazwisko, czyAdministrator) ";
            SQL += "VALUES (@login, @haslo,@imie,@nazwisko, @czyAdministrator);";

            string haslo = this.textBoxLogin.Text + "1";

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@login", textBoxLogin.Text);
            command.Parameters.AddWithValue("@haslo", haslo);
            command.Parameters.AddWithValue("@imie", textBoxImie.Text);
            command.Parameters.AddWithValue("@nazwisko", textBoxNazwisko.Text);
            command.Parameters.AddWithValue("@czyAdministrator", checkBoxCzyAdministrator.Checked);
           
            baza.Polaczenie.Open();
            command.ExecuteNonQuery();
            baza.Polaczenie.Close();
        }

        private void Edytuj()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "UPDATE korepetytor SET";
            SQL += " login = @login,";
            SQL += " imie = @imie,";
            SQL += " nazwisko = @nazwisko,";
            SQL += " czyAdministrator = @czyAdministrator";
            if(resetHasla)
            {
                SQL += ", haslo = @haslo";
            }
            SQL += " where id = @id";

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@login", textBoxLogin.Text);
            command.Parameters.AddWithValue("@imie", textBoxImie.Text);
            command.Parameters.AddWithValue("@nazwisko", textBoxNazwisko.Text);
            command.Parameters.AddWithValue("@czyAdministrator", checkBoxCzyAdministrator.Checked);
            baza.Polaczenie.Open();
            command.ExecuteNonQuery();
            baza.Polaczenie.Close();
        }


        private void btnPotwierdz_Click(object sender, EventArgs e)
        {
            if(Walidajca())
            {
                try
                {
                    if (trybEdycji)
                    {
                        Edytuj();
                    }
                    else
                    {
                        Dodaj();
                    }
                    sukces = true;
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Wystapił nieprzewidziany problem");
                    sukces = false;
                }
            }
        }

        public bool Sukces
        {
            get
            {
                return sukces;
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetujHaslo_Click(object sender, EventArgs e)
        {
            ResetHaslo okno = new ResetHaslo(textBoxLogin.Text, id);
            okno.ShowDialog(this);
        }
    }
}
