using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
                Console.WriteLine("Sikeres kapcsolódás!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void querySelect()
        {
            string qry = "SELECT `id`, `razon`, `active` FROM `serial` ORDER BY `id` ASC;";
            MySqlCommand cmd = new MySqlCommand(qry,connection);

            MySqlDataReader datareaderSelect = cmd.ExecuteReader();
            datareaderSelect.Read();
            
            do
            {
               
                Console.Write(datareaderSelect.GetValue(0).ToString() + "-");
                Console.Write(datareaderSelect.GetValue(1).ToString()+"-");
                Console.WriteLine(datareaderSelect.GetValue(2).ToString());
            } 
            while (datareaderSelect.Read()==true);

            datareaderSelect.Close();

        }

        public void queryDelete(int id)
        {
            try
            {
                string qry = "DELETE FROM `serial` WHERE `id`=" + id;
                MySqlCommand cmd = new MySqlCommand(qry, connection);
                MySqlDataReader datareaderDelete = cmd.ExecuteReader();
                datareaderDelete.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          

        }
    }
}
