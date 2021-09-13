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
    public partial class Logowanie : Form
    {
        
        string haslo;
        bool zalogowany;
        Uzytkownik uzytkownik;

        public Logowanie()
        {
            InitializeComponent();
            uzytkownik = null;
            zalogowany = false;
        }

        private bool Walidacja()
        {
            Walidator walidator = new Walidator();
            walidator.PoleTextoweWymagane(textBoxLogin, "login", 5, 30);
            walidator.PoleTextoweWymagane(textBoxHaslo, "haslo", 3, 30);

            return walidator.WalidacjaPoprawna;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPotwierdz_Click(object sender, EventArgs e)
        {
            if(Walidacja())
            {
                try
                {
                    BazaDanych baza = new BazaDanych();

                    string SQL = "SELECT id, imie, nazwisko, haslo, czyAdministrator FROM korepetytor WHERE login = @login;";

                    MySqlCommand command = new MySqlCommand(SQL, baza.Polaczenie);
                    command.Parameters.AddWithValue("@login", textBoxLogin.Text);


                    baza.Polaczenie.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    string haslo = "";
                    
                    while (dataReader.Read())
                    {
                        uzytkownik = new Uzytkownik(dataReader.GetInt32(0));
                        uzytkownik.Imie = BazaDanych.CzytajString(dataReader, 1);
                        uzytkownik.Nazwisko = BazaDanych.CzytajString(dataReader, 2);
                        haslo = BazaDanych.CzytajString(dataReader, 3);
                        uzytkownik.CzyAdministrator = BazaDanych.CzytajBool(dataReader, 4);
                        uzytkownik.Login = textBoxLogin.Text;
                    }
                    baza.Polaczenie.Close();

                    if(haslo == null)
                    {
                        MessageBox.Show("dane logowania są nie poprawne");
                        zalogowany = false;
                        return;
                    }

                    if(haslo.CompareTo(textBoxHaslo.Text) ==0)
                    {
                        zalogowany = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("dane logowania są nie poprawne");
                        zalogowany = false;
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystapił nieprzewidziany problem");
                    zalogowany = false;
                }
            }
        }

        public bool Zalogowany
        {
            get
            {
                return zalogowany;
            }
        }

        public Uzytkownik Uzytkownik
        {
            get
            {
                return uzytkownik;
            }
        }

        private void textBoxHaslo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Equals(Keys.Enter))
            {
                btnPotwierdz.PerformClick();
            }
        }
    }
}
