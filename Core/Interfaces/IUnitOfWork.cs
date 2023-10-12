using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IAuditoria Auditorias{get; set;}
        IBlockChain BlockChains{get; set;}
        IEstadoNotificacion EstadosNotificaciones{get; set;}
        IFormato Formatos{get; set;}
        IGenericossvSubModulos GenericossvSubsModulos{get; set;}
        IMaestrosvSubModulos MaestrosvSubsModulos{get; set;}
        IModuloNotificacion ModulosNotificaciones{get; set;}
        IModulosMaestros ModuloMaestros{get; set;}
        IPermisosGenericos PermisoGenerico{get; set;}
        IRadicado Radicados{get; set;}
        IRespuestaNotificacion RespuestasNotificaciones{get; set;}
        IRol Roles{get; set;}
        IRolvsMaestro RolsvsMaestros{get;set;}
        ISubModulo SubsModulos{get; set;}
        ITipoNotificacion TiposNotificaciones{get; set;}
        ITipoRequerimiento TiposRequerimientos{get; set;}
        
        Task<int> SaveAsync();
    }
}