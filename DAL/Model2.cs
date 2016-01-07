using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL2
{    
    public abstract class Login
    {
        public string userName;
        public string password;
        public Login(string LoginName, string LoginPassword)
        {
            this.userName = LoginName;
            this.password = LoginPassword;
        }
        public abstract string DomainLogin();
    }

    interface IFacebookLogin
    {
        string FacebookLogin(string user, string password);
    }

    public class PortalLogin : Login
    {
        PortalLogin(string LoginName, string LoginPassword):base(LoginName, LoginPassword){}
        public override string DomainLogin()
        {
            if (this.userName == "Bora" && this.password == "12345")
            {
                return "Wellcome Bora KAŞMER";
            }
            else {
                return "Your Domain Username or Password Wrong!";
            }
        }
    }
    public class SocialLogin : Login, IFacebookLogin
    {
        SocialLogin(string LoginName, string LoginPassword) : base(LoginName, LoginPassword) { }
        public override string DomainLogin()
        {
            if (this.userName == "Bora" && this.password == "12345")
            {
                return "Wellcome Bora KAŞMER";
            }
            else {
                return "Your Domain Username or Password Wrong!";
            }
        }

        public string FacebookLogin(string fbUserName, string password)
        {
            if (fbUserName == "FaceBora" && password == "654321")
            {
                return "Wellcome Facebook Borsoft";
            }
            else {
                return "Your Facebook Credentials Wrong!";
            }
        }
    }

}
