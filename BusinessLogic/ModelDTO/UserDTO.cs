using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.ModelDTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
