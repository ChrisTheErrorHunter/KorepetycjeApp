
namespace Korepetycje
{
    partial class ListaLekcji
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
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBoxSchowAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.Location = new System.Drawing.Point(829, 363);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(95, 23);
            this.btnAnuluj.TabIndex = 11;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(930, 363);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUsun.Location = new System.Drawing.Point(275, 363);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(117, 23);
            this.btnUsun.TabIndex = 9;
            this.btnUsun.Text = "Usuń ";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdytuj.Location = new System.Drawing.Point(152, 363);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(117, 23);
            this.btnEdytuj.TabIndex = 8;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodaj.Location = new System.Drawing.Point(12, 363);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(134, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1013, 345);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Uczeń";
            this.columnHeader1.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Korepetytor";
            this.columnHeader4.Width = 117;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Przedmiot";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Temat";
            this.columnHeader3.Width = 381;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Poczatek";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "czas";
            this.columnHeader6.Width = 45;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CzyZaplacona";
            this.columnHeader7.Width = 83;
            // 
            // checkBoxSchowAll
            // 
            this.checkBoxSchowAll.AutoSize = true;
            this.checkBoxSchowAll.Location = new System.Drawing.Point(398, 367);
            this.checkBoxSchowAll.Name = "checkBoxSchowAll";
            this.checkBoxSchowAll.Size = new System.Drawing.Size(103, 17);
            this.checkBoxSchowAll.TabIndex = 12;
            this.checkBoxSchowAll.Text = "pokaż wszystkie";
            this.checkBoxSchowAll.UseVisualStyleBackColor = true;
            this.checkBoxSchowAll.CheckedChanged += new System.EventHandler(this.checkBoxSchowAll_CheckedChanged);
            // 
            // ListaLekcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 398);
            this.Controls.Add(this.checkBoxSchowAll);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listView1);
            this.Name = "ListaLekcji";
            this.Text = "ListaLekcji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.CheckBox checkBoxSchowAll;
    }
}