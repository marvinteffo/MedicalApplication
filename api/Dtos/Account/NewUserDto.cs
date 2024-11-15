using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Account
{
    public class NewUserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string LastName { get; set; }
        
        public string Password { get; set; }  // Store hashed password in the service
        public string Role { get; set; }
    }
}