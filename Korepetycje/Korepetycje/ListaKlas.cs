﻿using MySql.Data.MySqlClient;
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
    public partial class ListaKlas : Form
    {
        Element element;
        
        public ListaKlas()
        {
            InitializeComponent();
            OdswierzListe();
            element = null;
        }

        private void OdswierzListe()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "SELECT id, nazwa, szkola, stopien FROM klasa";
            
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
                this.listView1.Items.Add(item);
            }

            baza.Polaczenie.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OknoKlasa okno = new OknoKlasa();
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
                OknoKlasa okno = new OknoKlasa(item.Id);
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

                    string sql = "DELETE FROM klasa WHERE id = " + item.Id;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                WierszViewItem item = (WierszViewItem)listView1.SelectedItems[0];
                this.element = new Element(item.Id, item.Text);
            }
                

            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaKlas_Load(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {
                    BazaDanych baza = new BazaDanych();

                    WierszViewItem item = (WierszViewItem)listView1.SelectedItems[0];

                    string sql = "DELETE FROM klasa WHERE id = " + item.Id;
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

        public Element ZanaczonyElement
        {
            get
            {
                return element;
            }
        }
    }
}
