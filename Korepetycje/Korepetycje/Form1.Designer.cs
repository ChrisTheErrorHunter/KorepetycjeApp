
namespace Korepetycje
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnKorepetytorzy = new System.Windows.Forms.Button();
            this.btnKlasy = new System.Windows.Forms.Button();
            this.btnPrzedmioty = new System.Windows.Forms.Button();
            this.btnLekcje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdministrator = new System.Windows.Forms.CheckBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_konta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Uczniowie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKorepetytorzy
            // 
            this.btnKorepetytorzy.Location = new System.Drawing.Point(12, 12);
            this.btnKorepetytorzy.Name = "btnKorepetytorzy";
            this.btnKorepetytorzy.Size = new System.Drawing.Size(183, 55);
            this.btnKorepetytorzy.TabIndex = 2;
            this.btnKorepetytorzy.Text = "Korepetytorzy";
            this.btnKorepetytorzy.UseVisualStyleBackColor = true;
            this.btnKorepetytorzy.Click += new System.EventHandler(this.btnKorepetytorzy_Click);
            // 
            // btnKlasy
            // 
            this.btnKlasy.Location = new System.Drawing.Point(12, 134);
            this.btnKlasy.Name = "btnKlasy";
            this.btnKlasy.Size = new System.Drawing.Size(183, 55);
            this.btnKlasy.TabIndex = 3;
            this.btnKlasy.Text = "Klasy";
            this.btnKlasy.UseVisualStyleBackColor = true;
            this.btnKlasy.Click += new System.EventHandler(this.btnKlasy_Click);
            // 
            // btnPrzedmioty
            // 
            this.btnPrzedmioty.Location = new System.Drawing.Point(12, 195);
            this.btnPrzedmioty.Name = "btnPrzedmioty";
            this.btnPrzedmioty.Size = new System.Drawing.Size(183, 55);
            this.btnPrzedmioty.TabIndex = 4;
            this.btnPrzedmioty.Text = "Przedmioty";
            this.btnPrzedmioty.UseVisualStyleBackColor = true;
            this.btnPrzedmioty.Click += new System.EventHandler(this.btnPrzedmioty_Click);
            // 
            // btnLekcje
            // 
            this.btnLekcje.Location = new System.Drawing.Point(12, 256);
            this.btnLekcje.Name = "btnLekcje";
            this.btnLekcje.Size = new System.Drawing.Size(183, 55);
            this.btnLekcje.TabIndex = 5;
            this.btnLekcje.Text = "Lekcje";
            this.btnLekcje.UseVisualStyleBackColor = true;
            this.btnLekcje.Click += new System.EventHandler(this.btnLekcje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "imie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "nazwisko:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAdministrator);
            this.groupBox1.Controls.Add(this.textBoxNazwisko);
            this.groupBox1.Controls.Add(this.textBoxImie);
            this.groupBox1.Controls.Add(this.textBoxLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(215, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 149);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uzytkownik";
            // 
            // checkBoxAdministrator
            // 
            this.checkBoxAdministrator.AutoSize = true;
            this.checkBoxAdministrator.Enabled = false;
            this.checkBoxAdministrator.Location = new System.Drawing.Point(120, 89);
            this.checkBoxAdministrator.Name = "checkBoxAdministrator";
            this.checkBoxAdministrator.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAdministrator.TabIndex = 13;
            this.checkBoxAdministrator.UseVisualStyleBackColor = true;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(120, 63);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.ReadOnly = true;
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 12;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(120, 42);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.ReadOnly = true;
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 11;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(120, 18);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.ReadOnly = true;
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "administrator:";
            // 
            // btn_konta
            // 
            this.btn_konta.Location = new System.Drawing.Point(12, 317);
            this.btn_konta.Name = "btn_konta";
            this.btn_konta.Size = new System.Drawing.Size(183, 55);
            this.btn_konta.TabIndex = 10;
            this.btn_konta.Text = "Finanse";
            this.btn_konta.UseVisualStyleBackColor = true;
            this.btn_konta.Click += new System.EventHandler(this.btn_konta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 382);
            this.Controls.Add(this.btn_konta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLekcje);
            this.Controls.Add(this.btnPrzedmioty);
            this.Controls.Add(this.btnKlasy);
            this.Controls.Add(this.btnKorepetytorzy);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKorepetytorzy;
        private System.Windows.Forms.Button btnKlasy;
        private System.Windows.Forms.Button btnPrzedmioty;
        private System.Windows.Forms.Button btnLekcje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxAdministrator;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_konta;
    }
}

