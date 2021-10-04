
namespace Korepetycje
{
    partial class OknoLekcja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPrzedmiot = new System.Windows.Forms.TextBox();
            this.textBoxKorepetytor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnPotwierdz = new System.Windows.Forms.Button();
            this.textBoxUczen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTemat = new System.Windows.Forms.TextBox();
            this.checkBoxCzyZaplacona = new System.Windows.Forms.CheckBox();
            this.btnWybierzUcznia = new System.Windows.Forms.Button();
            this.btnWybierzKorepetytora = new System.Windows.Forms.Button();
            this.btnWybierzPrzedmiot = new System.Windows.Forms.Button();
            this.numericUpDownCzas = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerPoczatekData = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPoczatekCzas = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCzas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPrzedmiot
            // 
            this.textBoxPrzedmiot.Location = new System.Drawing.Point(105, 86);
            this.textBoxPrzedmiot.Name = "textBoxPrzedmiot";
            this.textBoxPrzedmiot.ReadOnly = true;
            this.textBoxPrzedmiot.Size = new System.Drawing.Size(143, 20);
            this.textBoxPrzedmiot.TabIndex = 20;
            // 
            // textBoxKorepetytor
            // 
            this.textBoxKorepetytor.Location = new System.Drawing.Point(105, 60);
            this.textBoxKorepetytor.Name = "textBoxKorepetytor";
            this.textBoxKorepetytor.ReadOnly = true;
            this.textBoxKorepetytor.Size = new System.Drawing.Size(143, 20);
            this.textBoxKorepetytor.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "przedmiot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "korepetytor:";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.Location = new System.Drawing.Point(254, 206);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(99, 23);
            this.btnAnuluj.TabIndex = 21;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnPotwierdz
            // 
            this.btnPotwierdz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotwierdz.Location = new System.Drawing.Point(359, 206);
            this.btnPotwierdz.Name = "btnPotwierdz";
            this.btnPotwierdz.Size = new System.Drawing.Size(99, 23);
            this.btnPotwierdz.TabIndex = 23;
            this.btnPotwierdz.Text = "OK";
            this.btnPotwierdz.UseVisualStyleBackColor = true;
            this.btnPotwierdz.Click += new System.EventHandler(this.btnPotwierdz_Click);
            // 
            // textBoxUczen
            // 
            this.textBoxUczen.Location = new System.Drawing.Point(105, 34);
            this.textBoxUczen.Name = "textBoxUczen";
            this.textBoxUczen.ReadOnly = true;
            this.textBoxUczen.Size = new System.Drawing.Size(143, 20);
            this.textBoxUczen.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "uczeń:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "temat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "poczatek:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "czas w min:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "czy zaplacona:";
            // 
            // textBoxTemat
            // 
            this.textBoxTemat.Location = new System.Drawing.Point(105, 8);
            this.textBoxTemat.Name = "textBoxTemat";
            this.textBoxTemat.Size = new System.Drawing.Size(347, 20);
            this.textBoxTemat.TabIndex = 29;
            // 
            // checkBoxCzyZaplacona
            // 
            this.checkBoxCzyZaplacona.AutoSize = true;
            this.checkBoxCzyZaplacona.Location = new System.Drawing.Point(105, 163);
            this.checkBoxCzyZaplacona.Name = "checkBoxCzyZaplacona";
            this.checkBoxCzyZaplacona.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCzyZaplacona.TabIndex = 32;
            this.checkBoxCzyZaplacona.UseVisualStyleBackColor = true;
            // 
            // btnWybierzUcznia
            // 
            this.btnWybierzUcznia.Location = new System.Drawing.Point(254, 34);
            this.btnWybierzUcznia.Name = "btnWybierzUcznia";
            this.btnWybierzUcznia.Size = new System.Drawing.Size(99, 23);
            this.btnWybierzUcznia.TabIndex = 33;
            this.btnWybierzUcznia.Text = "Wybierz";
            this.btnWybierzUcznia.UseVisualStyleBackColor = true;
            this.btnWybierzUcznia.Click += new System.EventHandler(this.btnWybierzUcznia_Click);
            // 
            // btnWybierzKorepetytora
            // 
            this.btnWybierzKorepetytora.Location = new System.Drawing.Point(254, 59);
            this.btnWybierzKorepetytora.Name = "btnWybierzKorepetytora";
            this.btnWybierzKorepetytora.Size = new System.Drawing.Size(99, 23);
            this.btnWybierzKorepetytora.TabIndex = 34;
            this.btnWybierzKorepetytora.Text = "Wybierz";
            this.btnWybierzKorepetytora.UseVisualStyleBackColor = true;
            this.btnWybierzKorepetytora.Click += new System.EventHandler(this.btnWybierzKorepetytora_Click);
            // 
            // btnWybierzPrzedmiot
            // 
            this.btnWybierzPrzedmiot.Location = new System.Drawing.Point(254, 86);
            this.btnWybierzPrzedmiot.Name = "btnWybierzPrzedmiot";
            this.btnWybierzPrzedmiot.Size = new System.Drawing.Size(99, 23);
            this.btnWybierzPrzedmiot.TabIndex = 35;
            this.btnWybierzPrzedmiot.Text = "Wybierz";
            this.btnWybierzPrzedmiot.UseVisualStyleBackColor = true;
            this.btnWybierzPrzedmiot.Click += new System.EventHandler(this.btnWybierzPrzedmiot_Click);
            // 
            // numericUpDownCzas
            // 
            this.numericUpDownCzas.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownCzas.Location = new System.Drawing.Point(105, 140);
            this.numericUpDownCzas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCzas.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCzas.Name = "numericUpDownCzas";
            this.numericUpDownCzas.Size = new System.Drawing.Size(143, 20);
            this.numericUpDownCzas.TabIndex = 37;
            this.numericUpDownCzas.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // dateTimePickerPoczatekData
            // 
            this.dateTimePickerPoczatekData.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerPoczatekData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPoczatekData.Location = new System.Drawing.Point(105, 115);
            this.dateTimePickerPoczatekData.Name = "dateTimePickerPoczatekData";
            this.dateTimePickerPoczatekData.Size = new System.Drawing.Size(143, 20);
            this.dateTimePickerPoczatekData.TabIndex = 38;
            // 
            // dateTimePickerPoczatekCzas
            // 
            this.dateTimePickerPoczatekCzas.CustomFormat = "HH:mm";
            this.dateTimePickerPoczatekCzas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPoczatekCzas.Location = new System.Drawing.Point(254, 114);
            this.dateTimePickerPoczatekCzas.Name = "dateTimePickerPoczatekCzas";
            this.dateTimePickerPoczatekCzas.ShowUpDown = true;
            this.dateTimePickerPoczatekCzas.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerPoczatekCzas.TabIndex = 39;
            // 
            // OknoLekcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 241);
            this.Controls.Add(this.dateTimePickerPoczatekCzas);
            this.Controls.Add(this.dateTimePickerPoczatekData);
            this.Controls.Add(this.numericUpDownCzas);
            this.Controls.Add(this.btnWybierzPrzedmiot);
            this.Controls.Add(this.btnWybierzKorepetytora);
            this.Controls.Add(this.btnWybierzUcznia);
            this.Controls.Add(this.checkBoxCzyZaplacona);
            this.Controls.Add(this.textBoxTemat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrzedmiot);
            this.Controls.Add(this.textBoxKorepetytor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnPotwierdz);
            this.Controls.Add(this.textBoxUczen);
            this.Controls.Add(this.label1);
            this.Name = "OknoLekcja";
            this.Text = "OknoLekcja";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrzedmiot;
        private System.Windows.Forms.TextBox textBoxKorepetytor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnPotwierdz;
        private System.Windows.Forms.TextBox textBoxUczen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTemat;
        private System.Windows.Forms.CheckBox checkBoxCzyZaplacona;
        private System.Windows.Forms.Button btnWybierzUcznia;
        private System.Windows.Forms.Button btnWybierzKorepetytora;
        private System.Windows.Forms.Button btnWybierzPrzedmiot;
        private System.Windows.Forms.NumericUpDown numericUpDownCzas;
        private System.Windows.Forms.DateTimePicker dateTimePickerPoczatekData;
        private System.Windows.Forms.DateTimePicker dateTimePickerPoczatekCzas;
    }
}