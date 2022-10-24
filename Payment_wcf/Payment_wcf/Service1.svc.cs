using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace Payment_wcf
{
    public class Service1 : IService1
    {
        Connect c = new Connect();
        List<Customer> cust = new List<Customer>();
        public List<Customer> getCustomers()//*Ok
        {
            string qry = "SELECT `id`,`name`,`age`, city FROM `customer`;";

            MySqlCommand cmd = new MySqlCommand(qry, c.connection);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Customer customer = new Customer();
                
                customer.Id = int.Parse(dr.GetValue(0).ToString());
                customer.Name = dr.GetValue(1).ToString();
                customer.Age = int.Parse(dr.GetValue(2).ToString());
                customer.City = dr.GetValue(3).ToString();

                cust.Add(customer);
            }

            dr.Close();
            return cust;
        }      
        public Customer getCustomer(string id)
        {
          
            string qry = "SELECT `id`,`name`,`age`, city FROM `customer` WHERE id="+id+";";

            MySqlCommand cmd = new MySqlCommand(qry, c.connection);

            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            
                Customer customer = new Customer();

                customer.Id = int.Parse(dr.GetValue(0).ToString());
                customer.Name = dr.GetValue(1).ToString();
                customer.Age = int.Parse(dr.GetValue(2).ToString());
                customer.City = dr.GetValue(3).ToString();
            

            dr.Close();
            return customer;
        }

        public string deleteCustomer(string id)//*Ok
        {
            try
            {
                string qry = "DELETE FROM customer WHERE id=" + id;
                MySqlCommand cmd = new MySqlCommand(qry, c.connection);

                cmd.ExecuteNonQuery();

                return "Felhasználó törölve!";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public string postCustomer(string id, string name, string age, string city)//*Ok
        {
            try
            {
                string qry = "UPDATE `customer` SET `Name`='" + name + "',`Age`='" + age + "',`City`='" + city + "' WHERE Id=" + id;

                MySqlCommand cmd = new MySqlCommand(qry, c.connection);

                cmd.ExecuteNonQuery();

                return "Módosítás elvégezve!";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public string putCustomerPostman(Customer customer)//*Ok
        {
             try
            {
                string qry = "INSERT INTO `customer`(`name`, `age`, `city`) " +
                     "VALUES ('" + customer.Name + "'," + customer.Age + ",'" + customer.City + "');";

                MySqlCommand cmd = new MySqlCommand(qry, c.connection);

                cmd.ExecuteNonQuery();

                return "Felhasználó sikeresen hozzáadva!";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
    }
}
