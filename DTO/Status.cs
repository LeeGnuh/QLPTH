using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Status
    {
        public int id_status { get; set; }
        public DateTime time { get; set; }
        public int lesson { get; set; }
        public int id_comp { get; set; }
        public string detail { get; set; }
    }
}
