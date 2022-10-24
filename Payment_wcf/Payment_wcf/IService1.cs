using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Payment_wcf
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedResponse,
            UriTemplate = "getCustomer/{id}")
            ]
        Customer getCustomer(string id);

        [OperationContract]//*Ok
        [WebInvoke(Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.WrappedResponse,
           UriTemplate = "getCustomers")
           ]
        List<Customer> getCustomers();

        [OperationContract]//*Ok
        [WebInvoke(Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.WrappedResponse,
           UriTemplate = "postCustomer/{id}/{name}/{age}/{city}")
           ]

        string postCustomer(string id, string name, string age, string city);


        [OperationContract]//*Ok
        [WebInvoke(Method = "PUT",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.WrappedResponse,
           UriTemplate = "putCustomerPostman")
           ]
        string putCustomerPostman(Customer customer);

        [OperationContract]//*OK
        [WebInvoke(Method = "DELETE",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.WrappedResponse,
          UriTemplate = "deleteCustomer/{id}")
          ]

        string deleteCustomer(string id);

    }

   
}
