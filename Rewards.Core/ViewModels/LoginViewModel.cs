using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginSSOViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
