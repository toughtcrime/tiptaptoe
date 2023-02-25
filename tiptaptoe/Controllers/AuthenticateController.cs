using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TicTacToe.Requests;

namespace TicTacToe.Controllers
{
    [Route("[controller]")]
    public class AuthenticateController : Controller
    {
        private readonly ILogger<AuthenticateController> _logger;

        [HttpGet("SignIn")]
        public IActionResult Login() => View();
        [HttpGet("SignUp")]
        public IActionResult Register() => View();

        [HttpPost("signin/processing")]
        public async Task<IActionResult> Login(LoginRequest request)
        {

        }

        [HttpPost("signin/processing")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {

        }
        public AuthenticateController(ILogger<AuthenticateController> logger)
        {
            _logger = logger;
        }
    }
}