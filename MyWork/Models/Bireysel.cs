using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Models
{
    public class Bireysel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Meslegi { get; set; }
        public string ReferansFirma { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public virtual List<PaketList> PaketList { get; set; }
        public virtual IList<ReklamList> ReklamList { get; set; }
        public string Not { get; set; }
        public DateTime AppliedDate { get; set; }
    }
}
