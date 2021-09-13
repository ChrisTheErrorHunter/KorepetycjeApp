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
    public partial class OknoPrzedmiot : Form
    {
        private int id;
        private bool sukces;
        private bool trybEdycji;
        public OknoPrzedmiot()
        {
            InitializeComponent();
            id = -1;
            sukces = false;
            trybEdycji = false;
            this.btnPotwierdz.Text = "Dodaj";
        }

        public OknoPrzedmiot(int id)
        {
            InitializeComponent();
            this.id = id;
            sukces = false;
            trybEdycji = true;
            this.btnPotwierdz.Text = "OK";
            WczytajDane();

        }

        private void WczytajDane()
        {
            try
            {
                BazaDanych baza = new BazaDanych();

                string SQL = "SELECT nazwa, poziom, cena FROM przedmiot WHERE id = @id;";

                MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                command.Parameters.AddWithValue("@id", id);


                baza.Polaczenie.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    textBoxNazwa.Text = BazaDanych.CzytajString(dataReader, 0);
                    textBoxPoziom.Text = BazaDanych.CzytajString(dataReader, 1);
                    cenaUpDown.Text = BazaDanych.CzytajString(dataReader, 2);
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
            walidator.PoleTextoweWymagane(textBoxNazwa, "nazwa", 2, 30);

            return walidator.WalidacjaPoprawna;
        }
        private void Dodaj()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "INSERT INTO przedmiot (nazwa, poziom, cena) ";
            SQL += "VALUES (@nazwa, @poziom,@cena);";



            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@nazwa", textBoxNazwa.Text);
            command.Parameters.AddWithValue("@poziom", textBoxPoziom.Text);
            command.Parameters.AddWithValue("@cena", cenaUpDown.Text);

            baza.Polaczenie.Open();
            command.ExecuteNonQuery();
            baza.Polaczenie.Close();
        }

        private void Edytuj()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "UPDATE przedmiot SET";
            SQL += " nazwa = @nazwa,";
            SQL += " poziom = @poziom,";
            SQL += " cena = @cena";
            SQL += " where id = @id";

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nazwa", textBoxNazwa.Text);
            command.Parameters.AddWithValue("@poziom", textBoxPoziom.Text);
            command.Parameters.AddWithValue("@cena", cenaUpDown.Text);

            baza.Polaczenie.Open();
            command.ExecuteNonQuery();
            baza.Polaczenie.Close();
        }

        private void btnPotwierdz_Click(object sender, EventArgs e)
        {
            if (Walidajca())
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
                catch (Exception ex)
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
    }
}
