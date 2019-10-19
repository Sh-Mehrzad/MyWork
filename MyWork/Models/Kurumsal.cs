using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Models
{
    public class Kurumsal
    {        
        public int ID { get; set; }

        [Display(Name = "Firma Adı")]
        [Required]
        [MaxLength(150)]
        public string FirmaAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Adres { get; set; }
        public virtual Il Il { get; set; }
        public virtual Ilce Ilce { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public virtual List<PaketList> PaketList { get; set; }
        public virtual IList<ReklamList> ReklamList { get; set; }
        public string Yetkili { get; set; }
        public string GSM { get; set; }
        public string Not { get; set; }
        public DateTime AppliedDate { get; set; }
    }
}
