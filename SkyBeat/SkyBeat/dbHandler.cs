using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyBeat
{
    class dbHandler
    {
        private bool flag = false;
        private readonly string databaseconnection = @"Data source = .; Initial Catalog = dbdSkyBeat; Integrated security = SSPI";

        public string databaseconnect { get => databaseconnection; }

        private void name (string var)
        {
            using (SqlConnection var2 = new SqlConnection(var))
            {
                try
                {
                    var2.Open();
                    flag = true;
                }
                catch (SqlException e)
                {

                    MessageBox.Show(e.Message);
                    flag = false;
                }
            }
        }
    }
}
