using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Data.Configuration
{
    public class MaestrosvSubModulosConfiguration : IEntityTypeConfiguration<MaestrosvSubModulos>
    {
        public void Configure(EntityTypeBuilder<MaestrosvSubModulos> builder)
        {
            builder.ToTable("MaestrosvSubModulos");
            builder.HasKey(g=>g.Id);
            builder.Property(g=>g.Id);

            builder.HasOne(l=>l.ModuloMaestros)
            .WithMany(l=>l.MaestrosvSubsModulos)
            .HasForeignKey(l=>l.IdMaestro);

            builder.HasOne(i=>i.SubsModulos)
            .WithMany(i=>i.MaestrosvSubsModulos)
            .HasForeignKey(i=>i.IdSubModulo);
        }
    }
}