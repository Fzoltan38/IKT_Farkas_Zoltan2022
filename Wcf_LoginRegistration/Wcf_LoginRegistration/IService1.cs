using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace Wcf_LoginRegistration
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]

        [WebInvoke(Method = "*",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "loginCheck")]
        bool loginCheck(User user);

      
    }

   
}
