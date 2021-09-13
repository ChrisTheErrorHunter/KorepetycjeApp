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
    public partial class StudentsView : Form
    {
        Element element;

        public StudentsView()
        {
            InitializeComponent();
            OdswierzListe();
            element = null;
        }
        private void OdswierzListe()
        {
            BazaDanych baza = new BazaDanych();

            
            string SQL = "SELECT uczen.id, uczen.imie, uczen.nazwisko, klasa.nazwa " +
                    "FROM uczen JOIN klasa ON uczen.idKlasy = klasa.id";

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);

            baza.Polaczenie.Open();
            MySqlDataReader dataReader = command.ExecuteReader();
            listView1.Items.Clear();
            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                WierszViewItem item = new WierszViewItem(id, BazaDanych.CzytajString(dataReader, 1));
                item.SubItems.Add(BazaDanych.CzytajString(dataReader, 2));
                item.SubItems.Add(BazaDanych.CzytajString(dataReader, 3));
                this.listView1.Items.Add(item);
            }
            

            baza.Polaczenie.Close();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            OknoUczen okno = new OknoUczen();
            okno.ShowDialog(this);
            if (okno.Sukces)
            {
                OdswierzListe();
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                WierszViewItem item = (WierszViewItem)listView1.SelectedItems[0];
                OknoUczen okno = new OknoUczen(item.Id);
                okno.ShowDialog(this);
                if (okno.Sukces)
                {
                    OdswierzListe();
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

                    string sql = "DELETE FROM uczen WHERE id = " + item.Id;
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                WierszViewItem item = (WierszViewItem)listView1.SelectedItems[0];
                this.element = new Element(item.Id, item.Text+ " " + item.SubItems[1].Text);
            }
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Element ZanaczonyElement
        {
            get
            {
                return element;
            }
        }
    }
}
