using System.Collections.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Data.Configuration
{
    public class PermisosGenericosConfiguration : IEntityTypeConfiguration<PermisosGenericos>
    {
        public void Configure(EntityTypeBuilder<PermisosGenericos> builder)
        {
            builder.ToTable("PermisosGenericos");
            builder.HasKey(f=>f.Id);
            builder.Property(f=>f.Id);

            builder.Property(v=>v.NombrePermiso)
            .HasMaxLength(50);
        }
    }
}