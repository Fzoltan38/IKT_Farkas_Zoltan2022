using MySqlConnector;
using System.Windows.Forms;

namespace Payment_wcf
{
    public class Connect
    {
        public MySqlConnection connection;

        string db;
        string srv;
        string usr;
        string pass;

        string connectionstring;

        public Connect()
        {
            try
            {
                srv = "localhost";
                db = "login";
                usr = "root";
                pass = "";

                connectionstring = "SERVER=" + srv + ";" + "DATABASE=" + db + ";" + "UID=" + usr + ";"
                    + "PASSWORD=" + pass + ";" + "SslMode=None;";

                connection = new MySqlConnection(connectionstring);

                connection.Open();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }
    }
}