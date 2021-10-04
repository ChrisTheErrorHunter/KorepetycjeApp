
namespace Korepetycje
{
    partial class OknoKlasa
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
            this.textBoxStopien = new System.Windows.Forms.TextBox();
            this.textBoxSzkola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnPotwierdz = new System.Windows.Forms.Button();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStopien
            // 
            this.textBoxStopien.Location = new System.Drawing.Point(113, 64);
            this.textBoxStopien.Name = "textBoxStopien";
            this.textBoxStopien.Size = new System.Drawing.Size(143, 20);
            this.textBoxStopien.TabIndex = 12;
            // 
            // textBoxSzkola
            // 
            this.textBoxSzkola.Location = new System.Drawing.Point(113, 38);
            this.textBoxSzkola.Name = "textBoxSzkola";
            this.textBoxSzkola.Size = new System.Drawing.Size(143, 20);
            this.textBoxSzkola.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "stopień:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "szkoła:";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.Location = new System.Drawing.Point(72, 113);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(99, 23);
            this.btnAnuluj.TabIndex = 13;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnPotwierdz
            // 
            this.btnPotwierdz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotwierdz.Location = new System.Drawing.Point(177, 113);
            this.btnPotwierdz.Name = "btnPotwierdz";
            this.btnPotwierdz.Size = new System.Drawing.Size(99, 23);
            this.btnPotwierdz.TabIndex = 15;
            this.btnPotwierdz.Text = "OK";
            this.btnPotwierdz.UseVisualStyleBackColor = true;
            this.btnPotwierdz.Click += new System.EventHandler(this.btnPotwierdz_Click);
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(113, 12);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(143, 20);
            this.textBoxNazwa.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "nazwa:";
            // 
            // OknoKlasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 148);
            this.Controls.Add(this.textBoxStopien);
            this.Controls.Add(this.textBoxSzkola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnPotwierdz);
            this.Controls.Add(this.textBoxNazwa);
            this.Controls.Add(this.label1);
            this.Name = "OknoKlasa";
            this.Text = "OknoKlasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStopien;
        private System.Windows.Forms.TextBox textBoxSzkola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnPotwierdz;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Label label1;
    }
}