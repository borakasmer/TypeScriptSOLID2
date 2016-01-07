using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{  
    interface ILogin{
        string DomainLogin();
        string SocialLogin();
    }

    public class PortalLogin : ILogin
    {        
        public string DomainLogin() { return ""; }
        public string SocialLogin() { return ""; }
    }
    public class FacebookLogin : ILogin
    {        
        public string DomainLogin() { return ""; }
        public string SocialLogin() { return ""; }
    }

}
