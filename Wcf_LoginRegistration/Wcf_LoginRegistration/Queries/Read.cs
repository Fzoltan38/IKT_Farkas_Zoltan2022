using MySqlConnector;
using Payment_wcf;

namespace Wcf_LoginRegistration.Queries
{
    public class Read
    {
        Connect c=new Connect();
        public bool authentication(string uname, string pwd)
        {
            try
            {
                string qry = "SELECT `id` FROM `users` WHERE `uname`= @uname AND `pwd`= @pwd;";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.connection;
                cmd.Parameters.AddWithValue("@uname", uname);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.CommandText = qry;

                MySqlDataReader dr = cmd.ExecuteReader();             

                return dr.HasRows;
            }
            catch 
            {
                return false;
            }
        }
    }
}