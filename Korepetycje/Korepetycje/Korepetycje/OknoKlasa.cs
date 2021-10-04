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
    public partial class OknoKlasa : Form
    {
        private int id;
        private bool sukces;
        private bool trybEdycji;
        public OknoKlasa()
        {
            InitializeComponent();
            id = -1;
            sukces = false;
            trybEdycji = false;
            this.btnPotwierdz.Text = "Dodaj";
        }

        public OknoKlasa(int id)
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

                string SQL = "SELECT nazwa, szkola, stopien FROM klasa WHERE id = @id;";

                MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                command.Parameters.AddWithValue("@id", id);


                baza.Polaczenie.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    textBoxNazwa.Text = BazaDanych.CzytajString(dataReader, 0);
                    textBoxSzkola.Text = BazaDanych.CzytajString(dataReader, 1);
                    textBoxStopien.Text = BazaDanych.CzytajString(dataReader, 2);
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

            string SQL = "INSERT INTO klasa (nazwa, szkola, stopien) ";
            SQL += "VALUES (@nazwa, @szkola,@stopien);";

           

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@nazwa", textBoxNazwa.Text);
            command.Parameters.AddWithValue("@szkola", textBoxSzkola.Text);
            command.Parameters.AddWithValue("@stopien", textBoxStopien.Text);

            baza.Polaczenie.Open();
            command.ExecuteNonQuery();
            baza.Polaczenie.Close();
        }

        private void Edytuj()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "UPDATE klasa SET";
            SQL += " nazwa = @nazwa,";
            SQL += " szkola = @szkola,";
            SQL += " stopien = @stopien";
            SQL += " where id = @id";

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nazwa", textBoxNazwa.Text);
            command.Parameters.AddWithValue("@szkola", textBoxSzkola.Text);
            command.Parameters.AddWithValue("@stopien", textBoxStopien.Text);

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
