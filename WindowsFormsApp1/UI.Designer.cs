namespace WindowsFormsApp1
{
    partial class UI
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
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.cmbKnjigeKategorija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKnjige = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArtikal = new System.Windows.Forms.TextBox();
            this.btnPretrazivanje = new System.Windows.Forms.Button();
            this.btnDodajRacun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(49, 73);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(144, 24);
            this.cmbKategorije.TabIndex = 0;
            // 
            // cmbKnjigeKategorija
            // 
            this.cmbKnjigeKategorija.FormattingEnabled = true;
            this.cmbKnjigeKategorija.Location = new System.Drawing.Point(527, 73);
            this.cmbKnjigeKategorija.Name = "cmbKnjigeKategorija";
            this.cmbKnjigeKategorija.Size = new System.Drawing.Size(243, 24);
            this.cmbKnjigeKategorija.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategorije knjiga";
            // 
            // btnKnjige
            // 
            this.btnKnjige.Location = new System.Drawing.Point(221, 73);
            this.btnKnjige.Name = "btnKnjige";
            this.btnKnjige.Size = new System.Drawing.Size(152, 24);
            this.btnKnjige.TabIndex = 3;
            this.btnKnjige.Text = "Prikazi knjige";
            this.btnKnjige.UseVisualStyleBackColor = true;
            this.btnKnjige.Click += new System.EventHandler(this.btnPrikazKnjiga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Knjige iz izabrene kategorije sotirane po autorima";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.Enabled = false;
            this.dgv.Location = new System.Drawing.Point(12, 223);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(600, 200);
            this.dgv.TabIndex = 6;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj Artikla";
            // 
            // txtArtikal
            // 
            this.txtArtikal.Location = new System.Drawing.Point(527, 144);
            this.txtArtikal.Name = "txtArtikal";
            this.txtArtikal.Size = new System.Drawing.Size(243, 22);
            this.txtArtikal.TabIndex = 8;
            // 
            // btnPretrazivanje
            // 
            this.btnPretrazivanje.Location = new System.Drawing.Point(673, 387);
            this.btnPretrazivanje.Name = "btnPretrazivanje";
            this.btnPretrazivanje.Size = new System.Drawing.Size(115, 51);
            this.btnPretrazivanje.TabIndex = 9;
            this.btnPretrazivanje.Text = "Dalja uputstva";
            this.btnPretrazivanje.UseVisualStyleBackColor = true;
            this.btnPretrazivanje.Click += new System.EventHandler(this.btnPretrazivanje_Click);
            // 
            // btnDodajRacun
            // 
            this.btnDodajRacun.Location = new System.Drawing.Point(655, 201);
            this.btnDodajRacun.Name = "btnDodajRacun";
            this.btnDodajRacun.Size = new System.Drawing.Size(115, 34);
            this.btnDodajRacun.TabIndex = 10;
            this.btnDodajRacun.Text = "Naruci";
            this.btnDodajRacun.UseVisualStyleBackColor = true;
            this.btnDodajRacun.Click += new System.EventHandler(this.btnDodajRacun_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajRacun);
            this.Controls.Add(this.btnPretrazivanje);
            this.Controls.Add(this.txtArtikal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKnjige);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKnjigeKategorija);
            this.Controls.Add(this.cmbKategorije);
            this.Name = "UI";
            this.Text = "Projekat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.ComboBox cmbKnjigeKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKnjige;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArtikal;
        private System.Windows.Forms.Button btnPretrazivanje;
        private System.Windows.Forms.Button btnDodajRacun;
    }
}

