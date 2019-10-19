using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Configuration
{
    public class IlceConfiguration : IEntityTypeConfiguration<Ilce>
    {
        public void Configure(EntityTypeBuilder<Ilce> builder)
        {
            //builder.ToTable("Ilce");
            //builder.HasData
            //(
            //    new Ilce
            //    {
            //        ID = 1,
            //        IlceAdi = "Seyhan"
            //    },
            //    new Ilce
            //    {
            //        ID = 2,
            //        IlceAdi = "Yüreğir"
            //    },
            //    new Ilce
            //    {
            //        ID = 3,
            //        IlceAdi = "Çukurova"
            //    }
                //new Ilce
                //{
                //    ID = 4,
                //    IlceAdi = "Çankaya",
                //    Il = obj2
                //},
                //new Ilce
                //{
                //    ID = 5,
                //    IlceAdi = "Keçiören",
                //    Il = obj2
                //},
                //new Ilce
                //{
                //    ID = 6,
                //    IlceAdi = "Yenimahalle",
                //    Il = obj2
                //}
            //);
        }
    }
}
