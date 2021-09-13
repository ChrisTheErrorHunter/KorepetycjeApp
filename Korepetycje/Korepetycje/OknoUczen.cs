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
    public partial class OknoUczen : Form
    {
        private int id;
        private bool sukces;
        private bool trybEdycji;
        private int idKlasy;
        public OknoUczen()
        {
            InitializeComponent();
            id = -1;
            idKlasy = -1;
            sukces = false;
            trybEdycji = false;
            this.btnPotwierdz.Text = "Dodaj";
        }
        public OknoUczen(int id)
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

                string SQL = "SELECT uczen.imie, uczen.nazwisko, uczen.idKlasy, klasa.nazwa " +
                    "FROM uczen JOIN klasa ON uczen.idKlasy = klasa.id WHERE uczen.id = @id;";

                MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                command.Parameters.AddWithValue("@id", id);


                baza.Polaczenie.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                dataReader.Read();

                textBoxImie.Text = BazaDanych.CzytajString(dataReader, 0);
                textBoxNazwisko.Text = BazaDanych.CzytajString(dataReader, 1);
                idKlasy = dataReader.GetInt32(2);
                textBoxKlasa.Text = BazaDanych.CzytajString(dataReader, 3);


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
            walidator.PoleTextoweWymagane(textBoxImie, "nazwa", 2, 30);
            walidator.PoleTextoweWymagane(textBoxKlasa, "klasa", 1, 60);
            
            return walidator.WalidacjaPoprawna;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Dodaj()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "INSERT INTO uczen (imie, nazwisko, idKlasy) ";
            SQL += "VALUES (@imie,@nazwisko, @idKlasy);";

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@imie", textBoxImie.Text);
            command.Parameters.AddWithValue("@nazwisko", textBoxNazwisko.Text);
            command.Parameters.AddWithValue("@idKlasy", idKlasy);

            baza.Polaczenie.Open();
            command.ExecuteNonQuery();
            baza.Polaczenie.Close();

            SQL = "SELECT MAX(id) FROM konto; ";
            int newid;
            command = new MySqlCommand(SQL, baza.Polaczenie);
            baza.Polaczenie.Open();
            MySqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            newid = dataReader.GetInt32(0);
            newid++;
            baza.Polaczenie.Close();

             SQL = "INSERT INTO konto (idUcznia) ";
            SQL += "VALUES (@idUcznia);";

            command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@idUcznia", newid);

            baza.Polaczenie.Open();
            command.ExecuteNonQuery();
            baza.Polaczenie.Close();
        }

        private void Edytuj()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "UPDATE uczen SET";
            SQL += " imie = @imie,";
            SQL += " nazwisko = @nazwisko,";
            SQL += " idKlasy = @idKlasy";
            SQL += " where id = @id";

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@imie", textBoxImie.Text);
            command.Parameters.AddWithValue("@nazwisko", textBoxNazwisko.Text);
            command.Parameters.AddWithValue("@idKlasy", idKlasy);

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
            get { return sukces; }
        }

        private void btnWybierz_Click(object sender, EventArgs e)
        {
            ListaKlas lista = new ListaKlas();
            lista.ShowDialog(this);
            if(lista.ZanaczonyElement != null)
            {
                this.idKlasy = lista.ZanaczonyElement.Id;
                this.textBoxKlasa.Text = lista.ZanaczonyElement.Nazwa;
            }
        }
    }
}
