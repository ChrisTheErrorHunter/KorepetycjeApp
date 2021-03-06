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
    public partial class OknoZasil : Form
    {
        bool sukces = false;
        int id;

        public bool Sukces
        {
            get
            {
                return sukces;
            }
        }
        public OknoZasil(int id)
        {
            InitializeComponent();
            this.id = id;
            WczytajDane();
        }

        private void WczytajDane()
        {
            try
            {
                BazaDanych baza = new BazaDanych();

                string SQL = "SELECT CONCAT(uczen.imie, ' ', uczen.nazwisko) " +
                    "FROM konto JOIN uczen ON konto.idUcznia = uczen.id WHERE konto.id = @id;";

                MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                command.Parameters.AddWithValue("@id", id);


                baza.Polaczenie.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                label_dane.Text = BazaDanych.CzytajString(dataReader, 0);
                baza.Polaczenie.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystapił nieprzewidziany problem");
                sukces = false;
            }
        }

        private void Zasil()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "UPDATE konto SET";
            SQL += " saldo = saldo + @kwota,";
            SQL += " sum_przychod = sum_przychod + @kwota,";
            SQL += " sum_przy_rok = sum_przy_rok + @kwota,";
            SQL += " sum_przych_mies = sum_przych_mies + @kwota";
            SQL += " where id = @id";

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@kwota", numericUpDown1.Value);
            baza.Polaczenie.Open();
            command.ExecuteNonQuery();
            baza.Polaczenie.Close();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Zasil();
            sukces = true;
            this.Close();
        }
    }
}
