using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMadbestilling.Models
{
    public class Madbestillings
    {
        public int Madbestillingid { get; set; }
        public int Menuid { get; set; }
        [DataType(DataType.Date)]
        public DateTime MenuDato { get; set; }
        public String MenuTekst { get; set; }
        public int AntalBestillinger { get; set; }
        public String BestilingsType { get; set; }
        [DataType(DataType.Date)]
        public DateTime BestillingsDateTime { get; set; }
        public String Bruger { get; set; }



        public Madbestillings()
        {

        }
    }
}
