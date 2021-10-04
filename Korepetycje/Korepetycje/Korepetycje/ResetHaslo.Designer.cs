
namespace Korepetycje
{
    partial class ResetHaslo
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
            this.username = new System.Windows.Forms.Label();
            this.primepass = new System.Windows.Forms.TextBox();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resetujesz Hasło dla:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(121, 22);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(35, 13);
            this.username.TabIndex = 1;
            this.username.Text = "label2";
            // 
            // primepass
            // 
            this.primepass.Location = new System.Drawing.Point(66, 67);
            this.primepass.Name = "primepass";
            this.primepass.Size = new System.Drawing.Size(146, 20);
            this.primepass.TabIndex = 2;
            // 
            // confirmpass
            // 
            this.confirmpass.Location = new System.Drawing.Point(66, 111);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.Size = new System.Drawing.Size(146, 20);
            this.confirmpass.TabIndex = 3;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(197, 219);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 4;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(23, 219);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Anuluj";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Podaj nowe hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Potwierdź hasło";
            // 
            // ResetHaslo
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.primepass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "ResetHaslo";
            this.Text = "Reset Hasła";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Edytujesz;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox primepass;
        private System.Windows.Forms.TextBox confirmpass;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}