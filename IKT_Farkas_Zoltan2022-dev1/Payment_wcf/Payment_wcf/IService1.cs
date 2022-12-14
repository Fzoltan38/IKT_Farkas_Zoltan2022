using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Payment_wcf
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method = "*",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "getCustomer/{id}")
            ]
        Customer getCustomer(string id);

        [OperationContract]//*Ok
        [WebInvoke(Method = "*",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "getCustomers")
           ]
        List<Customer> getCustomers();

        [OperationContract]//*Ok
        [WebInvoke(Method = "*",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "postCustomer/{id}/{name}/{age}/{city}")
           ]

        string postCustomer(string id, string name, string age, string city);

        [OperationContract]//*Ok
        [WebInvoke(Method = "*",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "postCustomerBody")
           ]

        string postCustomerBody(Customer cust);


        [OperationContract]//*Ok
        [WebInvoke(Method = "*",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "putCustomer")
           ]
        string putCustomer(Customer customer);

        [OperationContract]//*OK
        [WebInvoke(Method = "*",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "deleteCustomer/{id}")
          ]

        string deleteCustomer(string id);

    }

   
}
