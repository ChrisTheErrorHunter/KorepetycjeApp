
namespace Korepetycje
{
    partial class ListaRachunkow
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnZaawansowane = new System.Windows.Forms.Button();
            this.btnObciaz = new System.Windows.Forms.Button();
            this.btnZasil = new System.Windows.Forms.Button();
            this.btn_korekta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 396);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Imię i nazwisko ucznia";
            this.columnHeader1.Width = 253;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Saldo";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Przychód w tym miesiącu";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Przychód w tym roku podatkowym";
            this.columnHeader4.Width = 183;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Przychód całkowity";
            this.columnHeader5.Width = 110;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.Location = new System.Drawing.Point(676, 414);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(58, 23);
            this.btnAnuluj.TabIndex = 21;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(740, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnZaawansowane
            // 
            this.btnZaawansowane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZaawansowane.Location = new System.Drawing.Point(413, 415);
            this.btnZaawansowane.Name = "btnZaawansowane";
            this.btnZaawansowane.Size = new System.Drawing.Size(132, 23);
            this.btnZaawansowane.TabIndex = 19;
            this.btnZaawansowane.Text = "Opcje zaawansowane";
            this.btnZaawansowane.UseVisualStyleBackColor = true;
            this.btnZaawansowane.Click += new System.EventHandler(this.btnZaawansowane_Click);
            // 
            // btnObciaz
            // 
            this.btnObciaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObciaz.Location = new System.Drawing.Point(152, 415);
            this.btnObciaz.Name = "btnObciaz";
            this.btnObciaz.Size = new System.Drawing.Size(117, 23);
            this.btnObciaz.TabIndex = 18;
            this.btnObciaz.Text = "Obciąż";
            this.btnObciaz.UseVisualStyleBackColor = true;
            this.btnObciaz.Click += new System.EventHandler(this.btnObciaz_Click);
            // 
            // btnZasil
            // 
            this.btnZasil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZasil.Location = new System.Drawing.Point(12, 415);
            this.btnZasil.Name = "btnZasil";
            this.btnZasil.Size = new System.Drawing.Size(134, 23);
            this.btnZasil.TabIndex = 17;
            this.btnZasil.Text = "Zasil";
            this.btnZasil.UseVisualStyleBackColor = true;
            this.btnZasil.Click += new System.EventHandler(this.btnZasil_Click);
            // 
            // btn_korekta
            // 
            this.btn_korekta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_korekta.Location = new System.Drawing.Point(275, 415);
            this.btn_korekta.Name = "btn_korekta";
            this.btn_korekta.Size = new System.Drawing.Size(132, 23);
            this.btn_korekta.TabIndex = 22;
            this.btn_korekta.Text = "Korekta";
            this.btn_korekta.UseVisualStyleBackColor = true;
            this.btn_korekta.Click += new System.EventHandler(this.btn_korekta_Click);
            // 
            // ListaRachunkow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.btn_korekta);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnZaawansowane);
            this.Controls.Add(this.btnObciaz);
            this.Controls.Add(this.btnZasil);
            this.Controls.Add(this.listView1);
            this.Name = "ListaRachunkow";
            this.Text = "ListaRachunkow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnZaawansowane;
        private System.Windows.Forms.Button btnObciaz;
        private System.Windows.Forms.Button btnZasil;
        private System.Windows.Forms.Button btn_korekta;
    }
}