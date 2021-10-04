
namespace Korepetycje
{
    partial class OknoPrzedmiot
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
            this.textBoxPoziom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnPotwierdz = new System.Windows.Forms.Button();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cenaUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cenaUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPoziom
            // 
            this.textBoxPoziom.Location = new System.Drawing.Point(111, 32);
            this.textBoxPoziom.Name = "textBoxPoziom";
            this.textBoxPoziom.Size = new System.Drawing.Size(143, 20);
            this.textBoxPoziom.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cena Podstawowa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Poziom:";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.Location = new System.Drawing.Point(52, 94);
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
            this.btnPotwierdz.Location = new System.Drawing.Point(157, 94);
            this.btnPotwierdz.Name = "btnPotwierdz";
            this.btnPotwierdz.Size = new System.Drawing.Size(99, 23);
            this.btnPotwierdz.TabIndex = 23;
            this.btnPotwierdz.Text = "OK";
            this.btnPotwierdz.UseVisualStyleBackColor = true;
            this.btnPotwierdz.Click += new System.EventHandler(this.btnPotwierdz_Click);
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(111, 6);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(143, 20);
            this.textBoxNazwa.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nazwa:";
            // 
            // cenaUpDown
            // 
            this.cenaUpDown.Location = new System.Drawing.Point(111, 59);
            this.cenaUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cenaUpDown.Name = "cenaUpDown";
            this.cenaUpDown.Size = new System.Drawing.Size(145, 20);
            this.cenaUpDown.TabIndex = 25;
            // 
            // OknoPrzedmiot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 129);
            this.Controls.Add(this.cenaUpDown);
            this.Controls.Add(this.textBoxPoziom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnPotwierdz);
            this.Controls.Add(this.textBoxNazwa);
            this.Controls.Add(this.label1);
            this.Name = "OknoPrzedmiot";
            this.Text = "OknoPrzedmiot";
            ((System.ComponentModel.ISupportInitialize)(this.cenaUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPoziom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnPotwierdz;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cenaUpDown;
    }
}