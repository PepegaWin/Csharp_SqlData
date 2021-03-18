using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DaljaUpustva : Form
    {

        static public List<Knjiga> finalrac;

        List<Knjiga> racun;
        int brArtikla;
        Knjiga knj;
        Baza baza;
        List<Knjiga> knjige;
        DataTable dt;
        OleDbDataAdapter dp;
        UI u;
        public DaljaUpustva()
        {
            InitializeComponent();
            baza = new Baza();
            knjige = new List<Knjiga>();
           
            u = new UI(dt, dp);
            racun = UI.rac;
            brArtikla = UI.brArtikl;

        }
       
        
        private void DaljaUpustva_Load(object sender, EventArgs e)
        {
            try
            {
                baza.OtvoriKon();
                dp = new OleDbDataAdapter("SELECT * FROM Racun", baza.Conn);
                dt = new DataTable();
                dp.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                baza.ZatvoriKon();
            }
        }

        private void btnPotrazi_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                baza.OtvoriKon();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;

                cmd.CommandText = "SELECT * FROM Knjiga ";
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    Knjiga book = new Knjiga();
                    book.Id_knjiga = int.Parse(rd["ID_knjiga"].ToString());
                    book.Naziv = rd["naziv"].ToString();
                    book.Autor = rd["autor"].ToString();
                    book.Cena = int.Parse(rd["cena"].ToString());
                    book.Popust = int.Parse(rd["popust"].ToString());
                    book.Id_kategorija = int.Parse(rd["id_kategorija"].ToString());
                    knjige.Add(book);
                }
                
                foreach (Knjiga k in knjige)
                {

                    if (k.Autor == txtAutor.Text)
                    {
                        txtRez.Text =  k.Naziv + k.Autor + k.Cena;

                        knj = k;
                    }
                    if (k.Naziv == txtNaslov.Text)
                    {
                        txtRez.Text =  k.Naziv + k.Autor + k.Cena;
                        
                        knj = k;
                    }
                     if (k.Autor == txtAutor.Text && k.Naziv == txtNaslov.Text)
                    {
                        txtRez.Text =  k.Naziv + k.Autor + k.Cena;
                        
                        knj = k;
                    }
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.ZatvoriKon();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
          
            if (txtRez.Text != string.Empty)
            {
                if (brArtikla >= 0) { 
                    racun.Add(knj);
                    brArtikla--;
                    MessageBox.Show($"Ostalo je jos {brArtikla} da narucite!");
                    finalrac = racun;
                    if (brArtikla == 0)
                    {
                        MessageBox.Show("Narucili ste sve artikle");
                    }
                }
              
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.ReadOnly = true;
            
        }

        private void btnKorekcije_Click(object sender, EventArgs e)
        {
            Conf fr = new Conf();
            fr.ShowDialog();
        }
    }
 }
