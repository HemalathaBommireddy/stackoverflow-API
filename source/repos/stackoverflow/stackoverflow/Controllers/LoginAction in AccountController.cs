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
    public class LoginAction_in_AccountController : ControllerBase
    {



        public class AccountController : Controller
        {
            private readonly IUserLoginStore<IdentityUser> LoginUserName;
            

        }
    }
}