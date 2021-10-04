
namespace Korepetycje
{
    partial class OknoZaawansowane
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
            this.btn_zeromonth = new System.Windows.Forms.Button();
            this.btn_zero_all = new System.Windows.Forms.Button();
            this.btn_zero_year = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_mies = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_rok = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_cal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_zeromonth
            // 
            this.btn_zeromonth.Location = new System.Drawing.Point(12, 101);
            this.btn_zeromonth.Name = "btn_zeromonth";
            this.btn_zeromonth.Size = new System.Drawing.Size(152, 23);
            this.btn_zeromonth.TabIndex = 1;
            this.btn_zeromonth.Text = "Zeruj przychód miesięczny";
            this.btn_zeromonth.UseVisualStyleBackColor = true;
            this.btn_zeromonth.Click += new System.EventHandler(this.btn_zeromonth_Click);
            // 
            // btn_zero_all
            // 
            this.btn_zero_all.Location = new System.Drawing.Point(12, 159);
            this.btn_zero_all.Name = "btn_zero_all";
            this.btn_zero_all.Size = new System.Drawing.Size(152, 23);
            this.btn_zero_all.TabIndex = 4;
            this.btn_zero_all.Text = "Zeruj przychód całkowity";
            this.btn_zero_all.UseVisualStyleBackColor = true;
            this.btn_zero_all.Click += new System.EventHandler(this.btn_zero_all_Click);
            // 
            // btn_zero_year
            // 
            this.btn_zero_year.Location = new System.Drawing.Point(12, 130);
            this.btn_zero_year.Name = "btn_zero_year";
            this.btn_zero_year.Size = new System.Drawing.Size(152, 23);
            this.btn_zero_year.TabIndex = 5;
            this.btn_zero_year.Text = "Zeruj przychód roczny";
            this.btn_zero_year.UseVisualStyleBackColor = true;
            this.btn_zero_year.Click += new System.EventHandler(this.btn_zero_year_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 211);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(152, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Wyjście";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Przychód miesięczny:";
            // 
            // lab_mies
            // 
            this.lab_mies.AutoSize = true;
            this.lab_mies.Location = new System.Drawing.Point(120, 9);
            this.lab_mies.Name = "lab_mies";
            this.lab_mies.Size = new System.Drawing.Size(35, 13);
            this.lab_mies.TabIndex = 8;
            this.lab_mies.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Przychód roczny:";
            // 
            // lab_rok
            // 
            this.lab_rok.AutoSize = true;
            this.lab_rok.Location = new System.Drawing.Point(120, 31);
            this.lab_rok.Name = "lab_rok";
            this.lab_rok.Size = new System.Drawing.Size(35, 13);
            this.lab_rok.TabIndex = 10;
            this.lab_rok.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Przychód całkowity:";
            // 
            // lab_cal
            // 
            this.lab_cal.AutoSize = true;
            this.lab_cal.Location = new System.Drawing.Point(120, 55);
            this.lab_cal.Name = "lab_cal";
            this.lab_cal.Size = new System.Drawing.Size(35, 13);
            this.lab_cal.TabIndex = 12;
            this.lab_cal.Text = "label6";
            // 
            // OknoZaawansowane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 247);
            this.Controls.Add(this.lab_cal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lab_rok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_mies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_zero_year);
            this.Controls.Add(this.btn_zero_all);
            this.Controls.Add(this.btn_zeromonth);
            this.Name = "OknoZaawansowane";
            this.Text = "OknoZaawansowane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_zeromonth;
        private System.Windows.Forms.Button btn_zero_all;
        private System.Windows.Forms.Button btn_zero_year;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_mies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_rok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_cal;
    }
}