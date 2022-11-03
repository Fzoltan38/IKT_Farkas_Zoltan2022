using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace serialGenaratorGUI
{
    class Queries
    {
<<<<<<< HEAD
         public void dbRead(ListBox listboxForm1)
         {
            listboxForm1.Items.Clear();
            
=======
        Connect c = new Connect();
        
        public void dbRead(ListBox listboxForm1)
        {
            listboxForm1.Items.Clear();

>>>>>>> d63132ac99e1ce495261330bc901f1413f5e897d
            string qry = "SELECT `id`,`razon`,`active` FROM `serial`;";

            MySqlCommand cmd=new MySqlCommand(qry,Connect.connection);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
<<<<<<< HEAD
                listboxForm1.Items.Add(dr.GetValue(0).ToString()+"-"+ dr.GetValue(1).ToString()+"-"+ dr.GetValue(2).ToString());
            }

            dr.Close();
         }
=======
                listboxForm1.Items.Add(dr.GetValue(0)+"-"+dr.GetValue(1)+"-"+dr.GetValue(2));
            }

            dr.Close();
        }

        public void dbCreate()
        {
            Random rnd = new Random();
         
            try
            {
                string qry = "INSERT INTO `serial`(`razon`, `active`) " +
                       "VALUES ('"+ rnd.Next(100000, 1000000).ToString() + "', 1);";

                MySqlCommand cmd = new MySqlCommand(qry, c.connection);

                cmd.ExecuteNonQuery();
            }
            catch 
            {
                dbCreate();
            }

        }

        public void dbDelete(ListBox listboxForm1)
        {
            /*textbox3.Text = listboxForm1.SelectedIndex.ToString();
            MessageBox.Show(listboxForm1.Items[listboxForm1.SelectedIndex].ToString());*/
            string[] split = listboxForm1.Items[listboxForm1.SelectedIndex].ToString().Split('-');
            
            string qry = "DELETE FROM serial WHERE id=" + split[0];
            MySqlCommand cmd = new MySqlCommand(qry,c.connection);

            cmd.ExecuteNonQuery();
        }

        string id;
        public void textPaste(ListBox listboxForm1, TextBox textbox1, TextBox textbox2)
        {
            string[] split = listboxForm1.Items[listboxForm1.SelectedIndex].ToString().Split('-');

            textbox1.Text = split[1];
            textbox2.Text = split[2];

            id = split[0];

        }

        public void dbUpdate(TextBox textbox1, TextBox textbox2)
        {
            try
            {
                string qry = "UPDATE `serial` SET `razon`='" + textbox1.Text + "'," +
                "`active`=" + textbox2.Text + " " + "WHERE id=" + id;

                MySqlCommand cmd = new MySqlCommand(qry, c.connection);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
          
        }
>>>>>>> d63132ac99e1ce495261330bc901f1413f5e897d
    }
}

