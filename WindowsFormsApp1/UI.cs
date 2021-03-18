using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI : Form
    {
        public static List<Knjiga> rac;
        public static int brArtikl;

        //Racun se prosledjuje i na drugu formu!

        
        List<Knjiga> Racun;
        
        //
        OleDbDataAdapter racunadp;
        DataTable RacunTb;
        Baza baza;
        List<Kategorija> kategorije;
        List<Knjiga> knjige;
        List<Knjiga> odredjeni;
        
        public UI()
        {
            InitializeComponent();
            baza = new Baza();
            kategorije = new List<Kategorija>();
            knjige = new List<Knjiga>();
            odredjeni = new List<Knjiga>();
            Racun = new List<Knjiga>();
        }
   
        public UI(DataTable dt, OleDbDataAdapter dp) : this() {
            RacunTb = dt;
            racunadp = dp;
        
        
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {   
            this.Text = "Baza Knjiga i Kategorija";
            try
            {
                baza.OtvoriKon();
                OleDbCommand com = new OleDbCommand();
                com.Connection = baza.Conn;
                com.CommandText = "SELECT * FROM Kategorija";
                OleDbDataReader rd = com.ExecuteReader();
                while (rd.Read())
                {
                    Kategorija k = new Kategorija();
                    k.Id_kategorije = int.Parse(rd["ID_kategorije"].ToString());
                    k.Naziv = rd["naziv"].ToString();
                    kategorije.Add(k);

                }
                cmbKategorije.DataSource = kategorije;
                cmbKategorije.DisplayMember = "Naziv";
                cmbKategorije.ValueMember = "Id_kategorije";


                racunadp =new OleDbDataAdapter("SELECT * FROM Racun", baza.Conn );
                RacunTb = new DataTable();
                racunadp.Fill(RacunTb);
                dgv.DataSource = RacunTb;




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

        private void CmbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKnjigeKategorija.Items.Clear();
            Kategorija k = new Kategorija();
            k = null;
            k = kategorije.Where(x => x.Id_kategorije == int.Parse(cmbKategorije.SelectedValue.ToString())).FirstOrDefault();
            
        }

       

        private void btnPrikazKnjiga_Click(object sender, EventArgs e)
        {


            try
            {
                baza.OtvoriKon();
                OleDbCommand com = new OleDbCommand();
                com.Connection = baza.Conn;
                com.CommandText = "SELECT * FROM Knjiga " ;
                OleDbDataReader rd = com.ExecuteReader();
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

               

                odredjeni = knjige.Where(x => x.Id_kategorija == int.Parse(cmbKategorije.SelectedValue.ToString())).OrderBy(x => x.Autor).ToList();

                cmbKnjigeKategorija.DataSource = odredjeni;


                cmbKnjigeKategorija.DisplayMember = "Autornaziv";
                cmbKnjigeKategorija.ValueMember = "Id_knjiga";
                knjige.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {

                baza.ZatvoriKon();
            }
        }

      
       
        private void btnPretrazivanje_Click(object sender, EventArgs e)
        {
            DaljaUpustva noviForm = new DaljaUpustva();
            noviForm.ShowDialog();
        }

        private void btnDodajRacun_Click(object sender, EventArgs e)
        {
            Knjiga k = new Knjiga();
            int brArtikal;
            try
            {
                baza.OtvoriKon();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;

                bool sucs;
                sucs = int.TryParse(txtArtikal.Text, out brArtikal);
                if (sucs)
                {

                    k = odredjeni.Where(x => x.Id_knjiga == int.Parse(cmbKnjigeKategorija.SelectedValue.ToString())).FirstOrDefault();

                 
                        Racun.Add(k);
                        brArtikal--;
                        MessageBox.Show($"Broj Artikla da narucite {brArtikal}");

                    brArtikl = brArtikal;
                    rac = Racun;
                        MessageBox.Show("Uspesno naruceno");
                        updatujtabelu(); 
                }
                  else
                        MessageBox.Show("Nije naruceno");
                        


                
               

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                baza.ZatvoriKon();
            }
        }

        public void updatujtabelu() {
            dgv.Update();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.ScrollBars = ScrollBars.Both;
        }
    }
}
