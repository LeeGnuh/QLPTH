using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public int id_acc { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int id_per { get; set; }
        public string full_name { get; set; }
        public bool acc_ban { get; set; }
    }
}
