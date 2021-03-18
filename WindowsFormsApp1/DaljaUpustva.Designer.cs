namespace WindowsFormsApp1
{
    partial class DaljaUpustva
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPotrazi = new System.Windows.Forms.Button();
            this.btnKorekcije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 209);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(600, 200);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(124, 46);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(145, 22);
            this.txtNaslov.TabIndex = 1;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(124, 91);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(145, 22);
            this.txtAutor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Po Naslovu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Po Autoru";
            // 
            // txtRez
            // 
            this.txtRez.Location = new System.Drawing.Point(375, 62);
            this.txtRez.Name = "txtRez";
            this.txtRez.Size = new System.Drawing.Size(254, 22);
            this.txtRez.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rezultat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pretraga vase knjige";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(375, 116);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(254, 27);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj na racun";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPotrazi
            // 
            this.btnPotrazi.Location = new System.Drawing.Point(124, 151);
            this.btnPotrazi.Name = "btnPotrazi";
            this.btnPotrazi.Size = new System.Drawing.Size(145, 23);
            this.btnPotrazi.TabIndex = 9;
            this.btnPotrazi.Text = "Potrazi";
            this.btnPotrazi.UseVisualStyleBackColor = true;
            this.btnPotrazi.Click += new System.EventHandler(this.btnPotrazi_Click);
            // 
            // btnKorekcije
            // 
            this.btnKorekcije.Location = new System.Drawing.Point(669, 364);
            this.btnKorekcije.Name = "btnKorekcije";
            this.btnKorekcije.Size = new System.Drawing.Size(98, 45);
            this.btnKorekcije.TabIndex = 11;
            this.btnKorekcije.Text = "Korekcije";
            this.btnKorekcije.UseVisualStyleBackColor = true;
            this.btnKorekcije.Click += new System.EventHandler(this.btnKorekcije_Click);
            // 
            // DaljaUpustva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 431);
            this.Controls.Add(this.btnKorekcije);
            this.Controls.Add(this.btnPotrazi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRez);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.dgv);
            this.Name = "DaljaUpustva";
            this.Text = "DaljaUpustva";
            this.Load += new System.EventHandler(this.DaljaUpustva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRez;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPotrazi;
        private System.Windows.Forms.Button btnKorekcije;
    }
}