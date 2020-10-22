using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.TokenOption
{
    public class JWT
    {
        public JWT(string access_token, string username)
        {
            this.Token = access_token;
            this.Username = username;
        }
        string Token { get; set; }
        string Username { get; set; }

    }
}
