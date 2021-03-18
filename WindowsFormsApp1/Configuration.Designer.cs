namespace WindowsFormsApp1
{
    partial class Conf
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label popustLabel;
            System.Windows.Forms.Label nazivlbl;
            this.cmbListaKnjiga = new System.Windows.Forms.ComboBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.popustTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRacun = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbKat = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            nazivLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            popustLabel = new System.Windows.Forms.Label();
            nazivlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(485, 63);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(45, 17);
            nazivLabel.TabIndex = 5;
            nazivLabel.Text = "naziv:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(485, 91);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(45, 17);
            autorLabel.TabIndex = 7;
            autorLabel.Text = "autor:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(485, 119);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(43, 17);
            cenaLabel.TabIndex = 9;
            cenaLabel.Text = "cena:";
            // 
            // popustLabel
            // 
            popustLabel.AutoSize = true;
            popustLabel.Location = new System.Drawing.Point(485, 145);
            popustLabel.Name = "popustLabel";
            popustLabel.Size = new System.Drawing.Size(55, 17);
            popustLabel.TabIndex = 11;
            popustLabel.Text = "popust:";
            // 
            // nazivlbl
            // 
            nazivlbl.AutoSize = true;
            nazivlbl.Location = new System.Drawing.Point(485, 173);
            nazivlbl.Name = "nazivlbl";
            nazivlbl.Size = new System.Drawing.Size(89, 17);
            nazivlbl.TabIndex = 13;
            nazivlbl.Text = "id kategorija:";
            // 
            // cmbListaKnjiga
            // 
            this.cmbListaKnjiga.FormattingEnabled = true;
            this.cmbListaKnjiga.Location = new System.Drawing.Point(12, 12);
            this.cmbListaKnjiga.Name = "cmbListaKnjiga";
            this.cmbListaKnjiga.Size = new System.Drawing.Size(230, 24);
            this.cmbListaKnjiga.TabIndex = 1;
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(274, 12);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(195, 24);
            this.btnUkloni.TabIndex = 2;
            this.btnUkloni.Text = "Uklonite knjigu sa racuna";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(574, 60);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(183, 22);
            this.nazivTextBox.TabIndex = 6;
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(574, 86);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(183, 22);
            this.autorTextBox.TabIndex = 8;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.Location = new System.Drawing.Point(574, 114);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(183, 22);
            this.cenaTextBox.TabIndex = 10;
            // 
            // popustTextBox
            // 
            this.popustTextBox.Location = new System.Drawing.Point(574, 142);
            this.popustTextBox.Name = "popustTextBox";
            this.popustTextBox.Size = new System.Drawing.Size(183, 22);
            this.popustTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dodajte novu knjigu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Porucite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRacun
            // 
            this.lblRacun.AutoSize = true;
            this.lblRacun.Location = new System.Drawing.Point(12, 273);
            this.lblRacun.Name = "lblRacun";
            this.lblRacun.Size = new System.Drawing.Size(53, 17);
            this.lblRacun.TabIndex = 17;
            this.lblRacun.Text = "Racun:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(451, 214);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(123, 29);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbKat
            // 
            this.cmbKat.FormattingEnabled = true;
            this.cmbKat.Location = new System.Drawing.Point(574, 173);
            this.cmbKat.Name = "cmbKat";
            this.cmbKat.Size = new System.Drawing.Size(183, 24);
            this.cmbKat.TabIndex = 19;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(243, 273);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(116, 23);
            this.btnPrikazi.TabIndex = 20;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // Conf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 335);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cmbKat);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblRacun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(popustLabel);
            this.Controls.Add(this.popustTextBox);
            this.Controls.Add(nazivlbl);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.cmbListaKnjiga);
            this.Name = "Conf";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Conf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListaKnjiga;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox popustTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRacun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbKat;
        private System.Windows.Forms.Button btnPrikazi;
    }
}