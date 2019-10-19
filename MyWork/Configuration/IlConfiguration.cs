using Microsoft.EntityFrameworkCore;
using MyWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Configuration
{
    public class IlConfiguration : IEntityTypeConfiguration<Il>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Il> builder)
        {
            builder.ToTable("Il");
            builder.HasData
                (
                    new Il
                    {
                        IlAdi = "Adana",
                        ID = 1
                    },
                    new Il
                    {
                        IlAdi = "Ankara",
                        ID = 2
                    },
                    new Il
                    {
                        IlAdi = "Adıyaman",
                        ID = 3
                    },
                    new Il
                    {
                        IlAdi = "Afyonkarahisar",
                        ID = 4
                    },
                    new Il
                    {
                        IlAdi = "Aksaray",
                        ID = 5
                    },
                    new Il
                    {
                        IlAdi = "Amasya",
                        ID = 6
                    },
                    new Il
                    {
                        IlAdi = "Antalya",
                        ID = 7
                    },
                    new Il
                    {
                        IlAdi = "Ardahan",
                        ID = 8
                    },
                    new Il
                    {
                        IlAdi = "Artvin",
                        ID = 9
                    },
                    new Il
                    {
                        IlAdi = "Aydın",
                        ID = 10
                    },
                    new Il
                    {
                        IlAdi = "Ağrı",
                        ID = 11
                    },
                    new Il
                    {
                        IlAdi = "Balıkesir",
                        ID = 12
                    },
                    new Il
                    {
                        IlAdi = "Bartın",
                        ID = 13
                    },
                    new Il
                    {
                        IlAdi = "Batman",
                        ID = 14
                    },
                    new Il
                    {
                        IlAdi = "Bayburt",
                        ID = 15
                    },
                    new Il
                    {
                        IlAdi = "Bilecik",
                        ID = 16
                    },
                    new Il
                    {
                        IlAdi = "Bingöl İli",
                        ID = 17
                    },
                    new Il
                    {
                        IlAdi = "Bitlis",
                        ID = 18
                    }
                );

            builder.ToTable("Reklam");

            builder.HasData
            (
                new Reklam
                {
                    ID = 1,
                    ReklamName = "AnaSayfa 01"
                },
                new Reklam
                {
                    ID = 2,
                    ReklamName = "AnaSayfa 02"
                },
                new Reklam
                {
                    ID = 3,
                    ReklamName = "AnaSayfa Firma"
                },
                new Reklam
                {
                    ID = 4,
                    ReklamName = "AnaSayfa Ürün"
                },
                new Reklam
                {
                    ID = 5,
                    ReklamName = "Blog (Haber Tanıtım)"
                },
                new Reklam
                {
                    ID = 6,
                    ReklamName = "Diğer ..."
                }
            );

            builder.ToTable("Paket");

            builder.HasData
            (
                new Paket
                {
                    ID = 1,
                    PaketName = "Standart"
                },
                new Paket
                {
                    ID = 2,
                    PaketName = "Silver"
                },
                new Paket
                {
                    ID = 3,
                    PaketName = "Gold"
                }
            );
        }
    }
}
