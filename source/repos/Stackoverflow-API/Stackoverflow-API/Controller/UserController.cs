using MethodsforAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPIModel;

namespace Stackoverflow_API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ISignUpClass _SignUpClass;
        public UserController(ISignUpClass signupclass)
        {
            _SignUpClass = signupclass;
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

        
        [HttpGet, Route("api/UserDetailsRegister/UserLogin/{_EmailId}/{_Password}")]
        public IEnumerable<UserDetailsRegister> UserSignUp(string _EmailId, string _Password)
        {

            return _SignUpClass.UserLogin(_EmailId, _Password);



        }
        [HttpPut, Route("api/UserDetailsRegister/ForgetPassword/{_Password}")]
        public bool ForgetPassword(string _Password)
        {

            return _SignUpClass.ForgetPassword(_Password);



        }

    }
}
    

