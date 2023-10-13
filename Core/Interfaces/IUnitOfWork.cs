using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IAuditoria Auditorias{get;}
        IBlockChain BlockChains{get;}
        IEstadoNotificacion EstadosNotificaciones{get;}
        IFormato Formatos{get;}
        IGenericossvSubModulos GenericossvSubsModulos{get;}
        IMaestrosvSubModulos MaestrosvSubsModulos{get;}
        IModuloNotificacion ModulosNotificaciones{get;}
        IModulosMaestros ModuloMaestros{get;}
        IPermisosGenericos PermisoGenerico{get;}
        IRadicado Radicados{get;}
        IRespuestaNotificacion RespuestasNotificaciones{get;}
        IRol Roles{get;}
        IRolvsMaestro RolsvsMaestros{get;}
        ISubModulo SubsModulos{get;}
        ITipoNotificacion TiposNotificaciones{get;}
        ITipoRequerimiento TiposRequerimientos{get;}
        
        Task<int> SaveAsync();
    }
}