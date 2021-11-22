using LoginViewModel;
using Methods_for_SignUp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stackoverflow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUp_in_AccountController : ControllerBase
    {
        // [Route("api/[controller]")]
        //[ApiController]

        private readonly ISignUpClass _SignUpClass;
            public SignUp_in_AccountController(ISignUpClass signupclass)
            {
             _SignUpClass = signupclass ;
            }
            [HttpPost, Route("api/Register")]
            public bool Register(UserDetailsRegister _UserDetailsRegister)
            {
                if (_SignUpClass.InsertUserDetailsIntoSignUpForm(_UserDetailsRegister))
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            [HttpGet, Route("api/Login")]
            public IEnumerable<UserDetailsRegister> UserSignUp( string _EmailId, string _Password)
            {

                return _SignUpClass.UserLogin(_EmailId, _Password);



            }
        
    }
}
