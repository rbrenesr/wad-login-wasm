using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Shared.DTOs
{
    public  class UserTokenDTO
    {
        public string Token { get; set; } = null!;
        public DateTime Expitarion { get; set; }
    }
}
