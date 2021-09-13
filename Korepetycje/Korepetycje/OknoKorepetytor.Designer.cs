
namespace Korepetycje
{
    partial class OknoKorepetytor
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxCzyAdministrator = new System.Windows.Forms.CheckBox();
            this.btnResetujHaslo = new System.Windows.Forms.Button();
            this.btnPotwierdz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(111, 12);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(143, 20);
            this.textBoxLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "czy administrator";
            // 
            // checkBoxCzyAdministrator
            // 
            this.checkBoxCzyAdministrator.AutoSize = true;
            this.checkBoxCzyAdministrator.Location = new System.Drawing.Point(111, 119);
            this.checkBoxCzyAdministrator.Name = "checkBoxCzyAdministrator";
            this.checkBoxCzyAdministrator.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCzyAdministrator.TabIndex = 5;
            this.checkBoxCzyAdministrator.UseVisualStyleBackColor = true;
            // 
            // btnResetujHaslo
            // 
            this.btnResetujHaslo.Location = new System.Drawing.Point(111, 90);
            this.btnResetujHaslo.Name = "btnResetujHaslo";
            this.btnResetujHaslo.Size = new System.Drawing.Size(134, 23);
            this.btnResetujHaslo.TabIndex = 4;
            this.btnResetujHaslo.Text = "Resetuj hasło";
            this.btnResetujHaslo.UseVisualStyleBackColor = true;
            this.btnResetujHaslo.Click += new System.EventHandler(this.btnResetujHaslo_Click);
            // 
            // btnPotwierdz
            // 
            this.btnPotwierdz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotwierdz.Location = new System.Drawing.Point(260, 154);
            this.btnPotwierdz.Name = "btnPotwierdz";
            this.btnPotwierdz.Size = new System.Drawing.Size(99, 23);
            this.btnPotwierdz.TabIndex = 7;
            this.btnPotwierdz.Text = "OK";
            this.btnPotwierdz.UseVisualStyleBackColor = true;
            this.btnPotwierdz.Click += new System.EventHandler(this.btnPotwierdz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.Location = new System.Drawing.Point(155, 154);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(99, 23);
            this.btnAnuluj.TabIndex = 6;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "imię:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "nazwisko:";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(111, 38);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(143, 20);
            this.textBoxImie.TabIndex = 2;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(111, 64);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(143, 20);
            this.textBoxNazwisko.TabIndex = 3;
            // 
            // OknoKorepetytor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 189);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnPotwierdz);
            this.Controls.Add(this.btnResetujHaslo);
            this.Controls.Add(this.checkBoxCzyAdministrator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Name = "OknoKorepetytor";
            this.Text = "OknoKorepetytor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxCzyAdministrator;
        private System.Windows.Forms.Button btnResetujHaslo;
        private System.Windows.Forms.Button btnPotwierdz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
    }
}