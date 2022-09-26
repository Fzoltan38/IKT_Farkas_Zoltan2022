using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace serialGenerator
{
    class Connect
    {
        public MySqlConnection connection;
        
        string db;
        string srv;
        string usr;
        string pass;

        string connectionstring;

        public Connect()
        {
            srv = "localhost";
            db = "serials";
            usr = "root";
            pass = "";

            connectionstring = "SERVER=" + srv + ";" + "DATABASE=" + db + ";" + "UID=" + usr + ";"
                + "PASSWORD=" + pass + ";" + "SslMode=None;";

            connection = new MySqlConnection(connectionstring);

            try
            {
                connection.Open();
                //MessageBox.Show("Sikeres csatlakozás!");
            
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
