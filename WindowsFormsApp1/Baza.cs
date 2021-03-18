using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.OleDb;

namespace WindowsFormsApp1
{


    class Baza
    {
        OleDbConnection conn;

        public Baza() {
            conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Windows10 Home\Desktop\Knjizara.accdb.mdb'";


        }
        public void OtvoriKon()
        {
            if (conn != null)
            {
                conn.Open();
            }

        }
        public void ZatvoriKon()
        {
            if (conn != null) {
                conn.Close();
            }
        }
        public OleDbConnection Conn { get => conn; set => conn = value; }
    }
}
