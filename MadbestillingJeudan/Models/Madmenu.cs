using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMadMenu.Models
{
    public class MadMenu
    {
        [Key]
        public int Menuid { get; set; }
        public String Menu { get; set; }
        public String Med_Hjem_Køkken { get; set; }

        [DataType(DataType.Date)]
        public DateTime Dato { get; set; }
        public int Uge { get; set; }
        public String UgeNavn { get; set; }
        public String MenuStatus { get; set; }

        public MadMenu()
        {

        }

    }
}
