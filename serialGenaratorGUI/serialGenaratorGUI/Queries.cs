using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace serialGenaratorGUI
{
    class Queries
    {
         public void dbRead(ListBox listboxForm1)
         {
            listboxForm1.Items.Clear();
            
            string qry = "SELECT `id`,`razon`,`active` FROM `serial`;";

            MySqlCommand cmd=new MySqlCommand(qry,Connect.connection);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listboxForm1.Items.Add(dr.GetValue(0).ToString()+"-"+ dr.GetValue(1).ToString()+"-"+ dr.GetValue(2).ToString());
            }

            dr.Close();
         }
    }
}

