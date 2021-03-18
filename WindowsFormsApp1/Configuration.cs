using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.CodeDom;
using System.Threading;
using System.Security.Policy;

namespace WindowsFormsApp1
{
    public partial class Conf : Form
    {
       
        public static void PrikaziRac (Racun rac)
        {   
            

        }
        public static Racun rc;
        DateTime datum;
        Baza baza;
        Knjiga k;
        public Conf()
        {
            InitializeComponent();
            baza = new Baza();
            k = new Knjiga();
            cmbListaKnjiga.DataSource = DaljaUpustva.finalrac;
            cmbListaKnjiga.DisplayMember = "Naziv";
            cmbListaKnjiga.ValueMember = "Id_knjiga";

        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            k = DaljaUpustva.finalrac.Where(x => x.Id_knjiga == int.Parse(cmbListaKnjiga.SelectedValue.ToString())).FirstOrDefault();     
            DaljaUpustva.finalrac.Remove(k);
            MessageBox.Show("Uspesno uklonjen!");
           
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sum = 0;

            try
            {
                baza.OtvoriKon();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = baza.Conn;
                string vreme = DateTime.Now.ToString("HH:mm");
                datum = DateTime.Now.Date;

                foreach (Knjiga kn in DaljaUpustva.finalrac)
                {
                    Sum += (kn.Cena - (kn.Cena / 100 * kn.Popust));
                }
                rc = new Racun(Sum, datum, vreme);
                cmd.CommandText = @"INSERT INTO 
                        Racun(cena,datum,vreme)
                        VALUES(@cena,@datum,@vreme)";

                cmd.Parameters.AddWithValue("cena", Sum);
                cmd.Parameters.AddWithValue("datum", datum);
                cmd.Parameters.AddWithValue("vreme", vreme);

                int rez = cmd.ExecuteNonQuery();
                if (rez > 0)
                {
                    MessageBox.Show("Uspesno naruceno");

                }
                else
                    MessageBox.Show("Niste narucili sve artikle");

                





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
        

        private static void Pauza()
        {
            
            Thread.Sleep(4000);

        }

        private void Conf_Load(object sender, EventArgs e)
        {
            cmbListaKnjiga.DataSource = DaljaUpustva.finalrac;
            cmbListaKnjiga.DisplayMember = "Naziv";
            cmbListaKnjiga.ValueMember = "Id_knjiga";


            try
            {
                List<Kategorija> kategorije = new List<Kategorija>();
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
                cmbKat.DataSource = kategorije;
                cmbKat.DisplayMember = "Naziv";
                cmbKat.ValueMember = "Id_kategorije";

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
            try
            {
                baza.OtvoriKon();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = @"INSERT INTO 
                        Knjiga(naziv,autor,cena,popust,id_kategorija)
                        VALUES(@naziv,@autor,@cena,@popust,@id_kategorije)";

                cmd.Parameters.AddWithValue("naziv",nazivTextBox.Text);
                cmd.Parameters.AddWithValue("autor", autorTextBox.Text);
                cmd.Parameters.AddWithValue("cena",int.Parse(cenaTextBox.Text));
                cmd.Parameters.AddWithValue("popust", int.Parse(popustTextBox.Text));
                cmd.Parameters.AddWithValue("id_kategorija", cmbKat.SelectedValue);
                int rez = cmd.ExecuteNonQuery();
                if (rez > 0)
                {
                    MessageBox.Show("Uspesna dodela knjige");

                }
                else
                    MessageBox.Show("Niste uspesno dodali");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally {
                baza.ZatvoriKon();
            }
            
         }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            Thread backgroundThread = new Thread(() => Pauza());
            backgroundThread.Start();
            while (backgroundThread.IsAlive)
            {
                lblRacun.Text = rc.ToString();
                backgroundThread.Abort();
            }


        }
    }


    
    
}
