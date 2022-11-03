using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Payment_wcf.Repositories.GET
{
    [ServiceContract]
    public interface IGetService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.WrappedResponse,
          UriTemplate = "getCustomerss")
          ]
        List<Customer> getCustomerss();
    }
}
