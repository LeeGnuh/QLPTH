using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Scheduce
    {
        public int id { get; set; }
        public string id_tea { get; set; }
        public int id_subj { get; set; }
        public int id_room { get; set; }
        public DateTime time { get; set; }
        public int lesson { get; set; }
        public int num_of_less { get; set; }
    }
}
