using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructura.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructura.Repository;

public class AuditoriaRepository : GenericRepository<Auditoria>, IAuditoria
{
    private readonly NotiContext _context;

    public AuditoriaRepository(NotiContext context)
        : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Auditoria>> GetAllAsync()
    {
        return await _context.Auditorias
            .Include(p => p.BlockChains)
            .ToListAsync();
    }

    public async Task<List<BlockChain>> GetBlockChainsByAuditoriaIdAsync(int auditoriaId)
    {
        return await _context.BlockChains.Where(d => d.IdAuditoria == auditoriaId).ToListAsync();
    }
    public async Task<Auditoria> GetByIdAsync(int id)
    {
        return await _context.Auditorias
            .Include(p => p.BlockChains)
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}
