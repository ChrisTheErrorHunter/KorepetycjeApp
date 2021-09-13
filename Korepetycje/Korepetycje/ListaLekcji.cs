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
    public partial class ListaLekcji : Form
    {
        Uzytkownik uzytkownik;
        public ListaLekcji()
        {
            InitializeComponent();
        }

        public ListaLekcji(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            this.uzytkownik = uzytkownik;
            OdswierzListe(checkBoxSchowAll.Checked);
            checkBoxSchowAll.Enabled = uzytkownik.CzyAdministrator;
        }



        private void OdswierzListe(bool all)
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "SELECT " +
                "lekcja.id, " +
               "CONCAT(uczen.imie, ' ', uczen.nazwisko), " +
               "CONCAT(korepetytor.imie, ' ', IFNULL(korepetytor.nazwisko,'')), " +
               "przedmiot.nazwa, " +
               "lekcja.temat, " +
                "lekcja.poczatek, " +
               "lekcja.czas, " +
               "lekcja.czyZaplacona " +


                "FROM lekcja " +
                "JOIN przedmiot ON lekcja.idPrzedmiotu = przedmiot.id " +
                "JOIN uczen ON lekcja.idUcznia = uczen.id " +
                "JOIN korepetytor ON lekcja.idKorepetytora = korepetytor.id";
            if(!all)
            {
                SQL += " where korepetytor.id = @id";
            }


            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            if (!all)
            {
                command.Parameters.AddWithValue("@id", uzytkownik.Id);
            }

            baza.Polaczenie.Open();
            MySqlDataReader dataReader = command.ExecuteReader();
            listView1.Items.Clear();
            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                string text = BazaDanych.CzytajString(dataReader, 1);
                WierszViewItem item = new WierszViewItem(id, text);
                item.SubItems.Add(BazaDanych.CzytajString(dataReader, 2));
                item.SubItems.Add(BazaDanych.CzytajString(dataReader, 3));
                item.SubItems.Add(BazaDanych.CzytajString(dataReader, 4));
                DateTime poczatek = dataReader.GetDateTime(5);
                item.SubItems.Add(poczatek.ToShortDateString()+" "+ poczatek.ToShortTimeString());
                item.SubItems.Add(dataReader.GetInt32(6)+"");
                item.SubItems.Add(BazaDanych.CzytajBoolJakoText(dataReader, 7));
                this.listView1.Items.Add(item);
            }

            baza.Polaczenie.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OknoLekcja okno = new OknoLekcja(uzytkownik);
            okno.ShowDialog(this);
            if (okno.Sukces)
            {
                OdswierzListe(checkBoxSchowAll.Checked);
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                WierszViewItem item = (WierszViewItem)listView1.SelectedItems[0];
                OknoLekcja okno = new OknoLekcja(item.Id, uzytkownik);
                okno.ShowDialog(this);
                if (okno.Sukces)
                {
                    OdswierzListe(checkBoxSchowAll.Checked);
                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {
                    BazaDanych baza = new BazaDanych();

                    WierszViewItem item = (WierszViewItem)listView1.SelectedItems[0];

                    string sql = "DELETE FROM lekcja WHERE id = " + item.Id;
                    MySqlCommand command = new MySqlCommand(sql, baza.Polaczenie);

                    baza.Polaczenie.Open();
                    command.ExecuteNonQuery();
                    baza.Polaczenie.Close();

                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystapił nieprzewidziany problem");

                }
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxSchowAll_CheckedChanged(object sender, EventArgs e)
        {
            OdswierzListe(checkBoxSchowAll.Checked);
        }
    }
}
