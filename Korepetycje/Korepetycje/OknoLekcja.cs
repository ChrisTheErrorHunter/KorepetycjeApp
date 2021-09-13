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
    public partial class OknoLekcja : Form
    {
        private int id;
        private bool sukces;
        private bool trybEdycji;
        Uzytkownik uzytkownik;
        private int idUcznia;
        private int idKorepetytora;
        private int idPrzedmiotu;

        public OknoLekcja()
        {
            InitializeComponent();
        }


        public OknoLekcja(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            id = -1;
            sukces = false;
            trybEdycji = false;
            this.btnPotwierdz.Text = "Dodaj";
            this.uzytkownik = uzytkownik;
            idKorepetytora = uzytkownik.Id;
            textBoxKorepetytor.Text = uzytkownik.Imie + " " + uzytkownik.Nazwisko;
            btnWybierzKorepetytora.Enabled = uzytkownik.CzyAdministrator;
        }

        public OknoLekcja(int id, Uzytkownik uzytkownik)
        {
            InitializeComponent();
            this.uzytkownik = uzytkownik;
            this.id = id;
            sukces = false;
            trybEdycji = true;
            this.btnPotwierdz.Text = "OK";
            WczytajDane();
            btnWybierzKorepetytora.Enabled = uzytkownik.CzyAdministrator;
        }

        private void WczytajDane()
        {
            try
            {
                BazaDanych baza = new BazaDanych();

                string SQL = "SELECT " +
               "lekcja.temat, " +
              "uczen.id, " +
               "CONCAT(uczen.imie, ' ', uczen.nazwisko), " +

             "korepetytor.id, " +
              "CONCAT(korepetytor.imie, ' ', IFNULL(korepetytor.nazwisko,'')), " +

               "przedmiot.id, " +
              "przedmiot.nazwa, " +

              "lekcja.poczatek, " +
              "lekcja.czas, " +
              "lekcja.czyZaplacona " +
              "FROM lekcja " +
               "JOIN przedmiot ON lekcja.idPrzedmiotu = przedmiot.id " +
               "JOIN uczen ON lekcja.idUcznia = uczen.id " +
               "JOIN korepetytor ON lekcja.idKorepetytora = korepetytor.id " +
               "WHERE lekcja.id = @id;";

                MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                command.Parameters.AddWithValue("@id", id);


                baza.Polaczenie.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    textBoxTemat.Text = BazaDanych.CzytajString(dataReader, 0);
                    
                    idUcznia = dataReader.GetInt32(1);
                    textBoxUczen.Text = BazaDanych.CzytajString(dataReader, 2);
                    
                    idKorepetytora = dataReader.GetInt32(3);
                    textBoxKorepetytor.Text = BazaDanych.CzytajString(dataReader, 4);

                    idPrzedmiotu = dataReader.GetInt32(5);
                    textBoxPrzedmiot.Text = BazaDanych.CzytajString(dataReader, 6);

                    DateTime poczatek = dataReader.GetDateTime(7);
                    dateTimePickerPoczatekData.Value = poczatek;
                    dateTimePickerPoczatekCzas.Value = poczatek;
                    numericUpDownCzas.Value = dataReader.GetInt32(8);

                    checkBoxCzyZaplacona.Checked = dataReader.GetBoolean(9);
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
            walidator.PoleTextoweWymagane(textBoxTemat, "temat", 1, 100);
            walidator.PoleTextoweWymagane(textBoxPrzedmiot, "przemiot", 1, 1000);
            walidator.PoleTextoweWymagane(textBoxUczen, "uczeń", 1, 1000);
            walidator.PoleTextoweWymagane(textBoxUczen, "korepetytor", 1, 1000);

            return walidator.WalidacjaPoprawna;
        }

        private void Dodaj()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "INSERT INTO lekcja (temat, idPrzedmiotu, idUcznia, idKorepetytora, poczatek, czas, czyZaplacona) ";
            SQL += "VALUES (@temat,@idPrzedmiotu, @idUcznia, @idKorepetytora, @poczatek, @czas, @czyZaplacona);";

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@temat", textBoxTemat.Text);
            command.Parameters.AddWithValue("@idPrzedmiotu", idPrzedmiotu);
            command.Parameters.AddWithValue("@idUcznia", idUcznia);
            command.Parameters.AddWithValue("@idKorepetytora", idKorepetytora);
            command.Parameters.AddWithValue("@poczatek", getCzas());
            command.Parameters.AddWithValue("@czas", (int)numericUpDownCzas.Value);
            command.Parameters.AddWithValue("@czyZaplacona", checkBoxCzyZaplacona.Checked);

            baza.Polaczenie.Open();
            command.ExecuteNonQuery();
            baza.Polaczenie.Close();
        }

        private void Edytuj()
        {
            BazaDanych baza = new BazaDanych();

            string SQL = "UPDATE lekcja SET";
            SQL += " temat = @temat, ";
            SQL += " idPrzedmiotu = @idPrzedmiotu, ";
            SQL += " idUcznia = @idUcznia, ";
            SQL += " idKorepetytora = @idKorepetytora, ";
            SQL += " poczatek = @poczatek, ";
            SQL += " czas = @czas, ";
            SQL += " czyZaplacona = @czyZaplacona";
            SQL += " where id = @id";

            MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@temat", textBoxTemat.Text);
            command.Parameters.AddWithValue("@idPrzedmiotu", idPrzedmiotu);
            command.Parameters.AddWithValue("@idUcznia", idUcznia);
            command.Parameters.AddWithValue("@idKorepetytora", idKorepetytora);
            command.Parameters.AddWithValue("@poczatek", getCzas());
            command.Parameters.AddWithValue("@czas", (int)numericUpDownCzas.Value);
            command.Parameters.AddWithValue("@czyZaplacona", checkBoxCzyZaplacona.Checked);

            baza.Polaczenie.Open();
            command.ExecuteNonQuery();
            baza.Polaczenie.Close();
        }
        private DateTime getCzas()
        {
            DateTime data = dateTimePickerPoczatekData.Value;
            DateTime czas = dateTimePickerPoczatekCzas.Value;

            return new DateTime(data.Year, data.Month, data.Day, czas.Hour, czas.Minute, 0);
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

        private void btnWybierzUcznia_Click(object sender, EventArgs e)
        {
            StudentsView lista = new StudentsView();
            lista.ShowDialog();
            if(lista.ZanaczonyElement != null)
            {
                this.textBoxUczen.Text = lista.ZanaczonyElement.Nazwa;
                this.idUcznia = lista.ZanaczonyElement.Id;
            }
            
        }

        private void btnWybierzKorepetytora_Click(object sender, EventArgs e)
        {
            ListaKorepetytorow lista = new ListaKorepetytorow();
            lista.ShowDialog();
            if (lista.ZanaczonyElement != null)
            {
                this.textBoxKorepetytor.Text = lista.ZanaczonyElement.Nazwa;
                this.idKorepetytora = lista.ZanaczonyElement.Id;
            }
        }

        private void btnWybierzPrzedmiot_Click(object sender, EventArgs e)
        {
            ListaPrzedmiotow lista = new ListaPrzedmiotow();
            lista.ShowDialog();
            if (lista.ZanaczonyElement != null)
            {
                this.textBoxPrzedmiot.Text = lista.ZanaczonyElement.Nazwa;
                this.idPrzedmiotu = lista.ZanaczonyElement.Id;
            }
        }

       

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
