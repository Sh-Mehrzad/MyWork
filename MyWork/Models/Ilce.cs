using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Models
{
    public class Ilce
    {
        public int ID { get; set; }
        public string IlceAdi { get; set; }
        public virtual Il Il { get; set; }
    }
}
