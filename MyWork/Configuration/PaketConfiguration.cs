using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Configuration
{
    public class PaketConfiguration : IEntityTypeConfiguration<Paket>
    {
        public void Configure(EntityTypeBuilder<Paket> builder)
        {
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
