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
    public partial class ListaRachunkow : Form
    {
        Uzytkownik uzytkownik;
        public ListaRachunkow(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            OdswierzListe();
            if(!uzytkownik.CzyAdministrator)
            {
                btnZaawansowane.Enabled = false;
                btn_korekta.Enabled = false;
            }
        }

        private void OdswierzListe()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "SELECT " +
               "konto.id, " +
               "CONCAT(uczen.imie, ' ', uczen.nazwisko), " +
               "konto.saldo, " +
               "konto.sum_przych_mies, " +
               "konto.sum_przy_rok, " +
               "konto.sum_przychod " +
               "FROM konto " +
               "JOIN uczen ON konto.idUcznia = uczen.id";


            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
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
                item.SubItems.Add(BazaDanych.CzytajString(dataReader, 5));
                this.listView1.Items.Add(item);
            }

            baza.Polaczenie.Close();
        }

        private void btnZasil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                WierszViewItem item = (WierszViewItem)listView1.SelectedItems[0];
                OknoZasil okno = new OknoZasil(item.Id);
                okno.ShowDialog(this);
                if (okno.Sukces)
                {
                    OdswierzListe();
                }
            }
        }

        private void btnObciaz_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                WierszViewItem item = (WierszViewItem)listView1.SelectedItems[0];
                OknoObciaz okno = new OknoObciaz(item.Id);
                okno.ShowDialog(this);
                if (okno.Sukces)
                {
                    OdswierzListe();
                }
            }
        }

        private void btn_korekta_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                WierszViewItem item = (WierszViewItem)listView1.SelectedItems[0];
                OknoKorekta okno = new OknoKorekta(item.Id);
                okno.ShowDialog(this);
                if (okno.Sukces)
                {
                    OdswierzListe();
                }
            }
        }

        private void btnZaawansowane_Click(object sender, EventArgs e)
        {
            OknoZaawansowane okno = new OknoZaawansowane();
            okno.ShowDialog(this);
            if (okno.Sukces)
            {
                OdswierzListe();
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
