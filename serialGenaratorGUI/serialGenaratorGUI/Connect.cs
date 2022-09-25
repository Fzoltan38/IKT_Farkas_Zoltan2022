using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace serialGenaratorGUI
{
    class Connect
    {
        public static MySqlConnection connection;
        
        string db;
        string srv;
        string usr;
        string pass;

        string connectionstring;

        public Connect(TextBox textboxForm1)
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
                textboxForm1.Text = "Sikeres csatlakozás!";
            
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
