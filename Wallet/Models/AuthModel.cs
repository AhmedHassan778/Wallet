using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Models
{
    public class AuthModel
    {
        public string Message { set; get; }
        public bool IsAuthenticated { get; set; }
        public string Username { set; get; }
        public string Email { set; get; }
        public List<string> Roles { set; get; }
        public string Token { set; get; }
        public DateTime ExpiresOn { set; get; }


    }
}
