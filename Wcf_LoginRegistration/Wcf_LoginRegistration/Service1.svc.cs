﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf_LoginRegistration
{
    public class Service1 : IService1
    {
        public string login(User user)
        {
            throw new NotImplementedException();
        }
    }
}