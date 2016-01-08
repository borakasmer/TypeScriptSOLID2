var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var Login = (function () {
    function Login(LoginName, LoginPassword) {
        this.userName = LoginName;
        this.password = LoginPassword;
    }
    return Login;
})();
var PortalLogin = (function (_super) {
    __extends(PortalLogin, _super);
    function PortalLogin(LoginName, LoginPassword) {
        _super.call(this, LoginName, LoginPassword);
    }
    PortalLogin.prototype.DomainLogin = function () {
        if (this.userName == 'Bora' && this.password == "12345") {
            return "Wellcome Bora KAŞMER";
        }
        else {
            return "Your Domain Username or Password Wrong!";
        }
    };
    return PortalLogin;
})(Login);
var SocialLogin = (function (_super) {
    __extends(SocialLogin, _super);
    function SocialLogin(LoginName, LoginPassword) {
        _super.call(this, LoginName, LoginPassword);
        this.LoginName = LoginName;
        this.LoginPassword = LoginPassword;
    }
    SocialLogin.prototype.DomainLogin = function () {
        if (this.userName == 'Bora' && this.password == "12345") {
            return "Wellcome Bora KAŞMER";
        }
        else {
            return "Your Domain Username or Password Wrong!";
        }
    };
    SocialLogin.prototype.FaceLogin = function (fbUserName, password) {
        if (fbUserName == 'FaceBora' && password == "654321") {
            return "Wellcome Facebook Borsoft";
        }
        else {
            return "Your Facebook Credentials Wrong!";
        }
    };
    return SocialLogin;
})(Login);
var faceLogin = new SocialLogin("Bora", "1234");
alert(faceLogin.DomainLogin());
alert(faceLogin.FaceLogin("FaceBora", "654321"));
