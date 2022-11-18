using Wcf_LoginRegistration.Queries;

namespace Wcf_LoginRegistration
{
    public class Service1 : IService1
    {
        public bool loginCheck(User user)
        {
            Read r = new Read();
            return r.authentication(user.uname, user.pwd);
        }
    }
}
