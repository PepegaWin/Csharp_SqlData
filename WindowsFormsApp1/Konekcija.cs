using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public class Baza
    {
        OleDbConnection conn;
        public Baza()
        {
            conn = new OleDbConnection();
           conn.ConnectionString= @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='CUsers\Windows10 Home\Desktop\Knjizara.accdb.mdb";
        }
    }
}
