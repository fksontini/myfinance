using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain
{
    public class Login
    {
        public string UserName { get; set; }

        public string Password { get; set; }

       

    }
}
