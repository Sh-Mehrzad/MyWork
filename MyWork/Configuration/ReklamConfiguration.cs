using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Configuration
{
    public class ReklamConfiguration : IEntityTypeConfiguration<Reklam>
    {
        public void Configure(EntityTypeBuilder<Reklam> builder)
        {
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
        }
    }
}
