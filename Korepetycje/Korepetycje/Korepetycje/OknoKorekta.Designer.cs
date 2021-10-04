
namespace Korepetycje
{
    partial class OknoKorekta
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saldoUpDown = new System.Windows.Forms.NumericUpDown();
            this.label_dane = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.przychcalUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.przychrokUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.przychmiesUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.saldoUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychcalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychrokUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychmiesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(106, 166);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(86, 27);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(15, 166);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(86, 27);
            this.btn_anuluj.TabIndex = 8;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Saldo:";
            // 
            // saldoUpDown
            // 
            this.saldoUpDown.Location = new System.Drawing.Point(130, 62);
            this.saldoUpDown.Name = "saldoUpDown";
            this.saldoUpDown.Size = new System.Drawing.Size(131, 20);
            this.saldoUpDown.TabIndex = 5;
            // 
            // label_dane
            // 
            this.label_dane.AutoSize = true;
            this.label_dane.Location = new System.Drawing.Point(12, 32);
            this.label_dane.Name = "label_dane";
            this.label_dane.Size = new System.Drawing.Size(35, 13);
            this.label_dane.TabIndex = 6;
            this.label_dane.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korekta dla ucznia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Przychod Sumaryczny:";
            // 
            // przychcalUpDown
            // 
            this.przychcalUpDown.Location = new System.Drawing.Point(130, 88);
            this.przychcalUpDown.Name = "przychcalUpDown";
            this.przychcalUpDown.Size = new System.Drawing.Size(131, 20);
            this.przychcalUpDown.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Przychód roczny:";
            // 
            // przychrokUpDown
            // 
            this.przychrokUpDown.Location = new System.Drawing.Point(130, 114);
            this.przychrokUpDown.Name = "przychrokUpDown";
            this.przychrokUpDown.Size = new System.Drawing.Size(131, 20);
            this.przychrokUpDown.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Przychód miesięczny:";
            // 
            // przychmiesUpDown
            // 
            this.przychmiesUpDown.Location = new System.Drawing.Point(130, 140);
            this.przychmiesUpDown.Name = "przychmiesUpDown";
            this.przychmiesUpDown.Size = new System.Drawing.Size(131, 20);
            this.przychmiesUpDown.TabIndex = 14;
            // 
            // OknoKorekta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 207);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.przychmiesUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.przychrokUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.przychcalUpDown);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saldoUpDown);
            this.Controls.Add(this.label_dane);
            this.Controls.Add(this.label1);
            this.Name = "OknoKorekta";
            this.Text = "OknoKorekta";
            ((System.ComponentModel.ISupportInitialize)(this.saldoUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychcalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychrokUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychmiesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown saldoUpDown;
        private System.Windows.Forms.Label label_dane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown przychcalUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown przychrokUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown przychmiesUpDown;
    }
}