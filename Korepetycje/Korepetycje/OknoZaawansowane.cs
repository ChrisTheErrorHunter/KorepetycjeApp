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
    public partial class OknoZaawansowane : Form
    {
        bool sukces = false;
        public bool Sukces
        {
            get
            {
                return sukces;
            }
        }
        public OknoZaawansowane()
        {
            InitializeComponent();
            WczytajDane();
        }

        private void WczytajDane()
        {
            try
            {
                BazaDanych baza = new BazaDanych();

                string SQL = "SELECT SUM(sum_przych_mies)," +
                    " SUM(sum_przy_rok)," +
                    " SUM(sum_przychod)" + 
                    " FROM konto";

                MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);

                baza.Polaczenie.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                lab_mies.Text = Convert.ToString(dataReader.GetInt32(0));
                lab_rok.Text = Convert.ToString(dataReader.GetInt32(1));
                lab_cal.Text = Convert.ToString(dataReader.GetInt32(2));
                baza.Polaczenie.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystapił nieprzewidziany problem");
                sukces = false;
            }
        }

        private void btn_zeromonth_Click(object sender, EventArgs e)
        {
            Potwierdzenie okno = new Potwierdzenie();
            okno.ShowDialog();
            if(okno.Potwierdzono)
            {
                try
                {
                    BazaDanych baza = new BazaDanych();

                    string SQL = "UPDATE konto" +
                        " SET sum_przych_mies = 0" +
                        " WHERE 1";

                    MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                    baza.Polaczenie.Open();
                    command.ExecuteNonQuery();
                    baza.Polaczenie.Close();
                    MessageBox.Show("Wyzerowano przychód miesięczny");
                    WczytajDane();
                    sukces = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystapił nieprzewidziany problem");
                    sukces = false;
                }
            }
        }

        private void btn_zero_year_Click(object sender, EventArgs e)
        {
            Potwierdzenie okno = new Potwierdzenie();
            okno.ShowDialog();
            if (okno.Potwierdzono)
            {
                try
                {
                    BazaDanych baza = new BazaDanych();

                    string SQL = "UPDATE konto" +
                        " SET sum_przy_rok = 0" +
                        " WHERE 1";

                    MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                    baza.Polaczenie.Open();
                    command.ExecuteNonQuery();
                    baza.Polaczenie.Close();
                    MessageBox.Show("Wyzerowano przychód roczny");
                    WczytajDane();
                    sukces = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystapił nieprzewidziany problem");
                    sukces = false;
                }
            }
        }

        private void btn_zero_all_Click(object sender, EventArgs e)
        {
            Potwierdzenie okno = new Potwierdzenie();
            okno.ShowDialog();
            if (okno.Potwierdzono)
            {
                try
                {
                    BazaDanych baza = new BazaDanych();

                    string SQL = "UPDATE konto" +
                        " SET sum_przychod = 0" +
                        " WHERE 1";

                    MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                    baza.Polaczenie.Open();
                    command.ExecuteNonQuery();
                    baza.Polaczenie.Close();
                    MessageBox.Show("Wyzerowano przychód");
                    WczytajDane();
                    sukces = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystapił nieprzewidziany problem");
                    sukces = false;
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
