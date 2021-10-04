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
    public partial class OknoKorekta : Form
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
        public OknoKorekta(int id)
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

                string SQL = "SELECT CONCAT(uczen.imie, ' ', uczen.nazwisko)," +
                    " konto.saldo," +
                    " konto.sum_przychod," +
                    " konto.sum_przy_rok," +
                    " konto.sum_przych_mies" +
                    " FROM konto JOIN uczen ON konto.idUcznia = uczen.id WHERE konto.id = @id;";

                MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                command.Parameters.AddWithValue("@id", id);


                baza.Polaczenie.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                label_dane.Text = BazaDanych.CzytajString(dataReader, 0);
                saldoUpDown.Value = dataReader.GetInt32(1);
                przychcalUpDown.Value = dataReader.GetInt32(2);
                przychrokUpDown.Value = dataReader.GetInt32(3);
                przychmiesUpDown.Value = dataReader.GetInt32(4);
                baza.Polaczenie.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystapił nieprzewidziany problem");
                sukces = false;
            }
        }

        private void Korektuj()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "UPDATE konto SET";
            SQL += " saldo = @saldo,";
            SQL += " sum_przychod = @sum,";
            SQL += " sum_przy_rok =  @rok,";
            SQL += " sum_przych_mies = @mies";
            SQL += " where id = @id";

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@saldo", saldoUpDown.Value);
            command.Parameters.AddWithValue("@sum", przychcalUpDown.Value);
            command.Parameters.AddWithValue("@rok", przychrokUpDown.Value);
            command.Parameters.AddWithValue("@mies", przychmiesUpDown.Value);
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
            Korektuj();
            sukces = true;
            this.Close();
        }
    }
}
