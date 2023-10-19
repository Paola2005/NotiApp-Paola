using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IPermisosGenericos:IGenericRepository<PermisosGenericos>
    {
        Task<List<GenericosvsSubModulos>> PermisosId(int genericopermisoId);
    }
}