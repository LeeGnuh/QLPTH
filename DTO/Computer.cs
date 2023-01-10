using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Computer
    {
        public int id_comp { get; set; }
        public int id_room { get; set; }
        public string comp_name { get; set; }
        public bool present_status { get; set; }
    }
}
