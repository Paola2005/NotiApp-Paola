using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Data.Configuration
{
    public class RolvsMaestroConfiguration : IEntityTypeConfiguration<RolvsMaestro>
    {
        public void Configure(EntityTypeBuilder<RolvsMaestro> builder)
        {
            builder.ToTable("RolvsMaestro");
            builder.HasKey(l=>l.Id);
            builder.Property(l=>l.Id);

            builder.HasOne(w=>w.Roles)
            .WithMany(w=>w.RolsvsMaestros)
            .HasForeignKey(w=>w.IdRol);

            builder.HasOne(p=>p.ModuloMaestros)
            .WithMany(p=>p.RolsvsMaestros)
            .HasForeignKey(p=>p.IdMaestro);



        }
    }
}