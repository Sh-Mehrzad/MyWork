using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Models
{
    public class PaketList
    {
        public int ID { get; set; }
        public virtual Kurumsal Kurumsal  { get; set; }
        public virtual  Bireysel Bireysel { get; set; }
        public DateTime AppliedDate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime EndDate { get; set; }
        public Paket Paket { get; set; }
    }
}
