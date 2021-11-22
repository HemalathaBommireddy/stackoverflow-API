using LoginViewModel;
using System;
using System.Collections.Generic;
using System.Text;


namespace Methods_for_SignUp
{
    public interface ISignUpClass
    {
        bool InsertUserDetailsIntoSignUpForm(UserDetailsRegister _UserDetailsRegister);
        // bool Register(string _emailid,string _password,string_name,string_conformpassword);
        IEnumerable<UserDetailsRegister> UserLogin( string _EmailId,string _Password);
    }
}
