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
    public class BlockChainConfiguration : IEntityTypeConfiguration<BlockChain>
    {
        public void Configure(EntityTypeBuilder<BlockChain> builder)
        {
            builder.ToTable("BlockChain");
            builder.HasKey(p=>p.Id);
            builder.Property(p=>p.Id);
    
            builder.HasOne(p => p.Auditorias)
            .WithMany(p => p.BlockChains)
            .HasForeignKey(p => p.IdAuditoria);

            builder.HasOne(z=>z.TiposNotificaciones)
            .WithMany(z=>z.BlockChains)
            .HasForeignKey(z=>z.IdNotificacion);

            builder.HasOne(u=>u.RespuestasNotificaciones)
            .WithMany(u=>u.BlockChains)
            .HasForeignKey(u=>u.IdHiloRespuesta);

            builder.Property(j=>j.HashGenerado)
            .HasMaxLength(100);

        }
    }
}