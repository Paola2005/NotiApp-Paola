using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Data.Configuration
{
    public class FormatoConfiguration : IEntityTypeConfiguration<Formato>
    {
        public void Configure(EntityTypeBuilder<Formato> builder)
        {
            builder.ToTable("Formato");
            builder.HasKey(y=>y.Id);
            builder.Property(E=>E.Id);

            builder.Property(u=>u.NombreFormato)
            .HasMaxLength(50);

            
        }
    }
}