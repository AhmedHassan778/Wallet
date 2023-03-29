using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Helpers
{
    public class JWT
    {
        public string Key { get; set; }
        public string issuer { get; set; }
        public string Audience { get; set; }
        public int DurationInDays { get; set; }
    }
}
