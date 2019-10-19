using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Models
{
    public class Il
    {
        [Key]
        public int ID { get; set; }
        public string IlAdi { get; set; }
        public virtual IList<Ilce> IlceList { get; set; }
    }
}
