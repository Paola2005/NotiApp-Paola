using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Data.Configuration
{
    public class SubModulosConfiguration : IEntityTypeConfiguration<SubModulos>
    {
        public void Configure(EntityTypeBuilder<SubModulos> builder)
        {
            builder.ToTable("SubModulos");
            builder.HasKey(n=>n.Id);
            builder.Property(w=>w.Id);

            builder.Property(i=>i.NombreSubModulo)
            .HasMaxLength(80);
        }
    }
}