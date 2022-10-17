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
        List<Customer> cust = new List<Customer>();
        public Customer getCustomer()
        {
            cust.Add(new Customer());
            return cust[0];
        }

        public void feltolt()
        {
            Customer c = new Customer();

            c.Id = 2;
            c.Name = "Gábor";
            c.City = "Pécs";

            cust.Add(c);

            Customer c2 = new Customer();

            c2.Id = 3;
            c2.Name = "Péter";
            c2.City = "Miskolc";

            cust.Add(c2);
        }
        public List<Customer> getCustomers()
        {
            feltolt();
            return cust;
        }
    }
}
