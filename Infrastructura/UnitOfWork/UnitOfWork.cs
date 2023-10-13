using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructura.Data;
using Infrastructura.Repository;

namespace Infrastructura.UnitOfWork
{
    public class UnitOfWork :IUnitOfWork,IDisposable
    {
        private readonly NotiContext _context;

        private AuditoriaRepository _auditorias ;
        private BlockChainRepository _blockChains ;
        private EstadoNotificacionRepository _estadosNotificaciones ;
        private FormatoRepository _formatos ;
        private GenericosvsSubModulosRepository _genericossvSubsModulos ;
        private MaestrosvSubModulosRepository _maestrosvSubsModulos ;
        private ModuloNotificacionRepository _modulosNotificaciones ;
        private ModulosMaestrosRepository _moduloMaestros ;
        private PermisosGenericosRepository _permisoGenerico ;
        private RadicadoRepository _radicados ;
        private RespuestaNotificacionRepository _respuestasNotificaciones ;
        private RolRepository _roles ;
        private RolvsMaestroRepository _rolsvsMaestros ;
        private SubModulosRepository _subsModulos ;
        private TipoNotificacionRepository _tiposNotificaciones ;
        private TipoRequerimientoRepository _tiposRequerimientos ;

        public IAuditoria Auditorias{
            get{
                if(_auditorias==null)
                {
                    _auditorias=new AuditoriaRepository(_context);
                }
                return _auditorias;
            }
        }

        public IBlockChain BlockChains{
            get{
                if(_blockChains==null)
                {
                    _blockChains=new BlockChainRepository(_context);
                }
                return _blockChains;
            }
        }

        public IEstadoNotificacion EstadosNotificaciones{
            get{
                if(_estadosNotificaciones==null)
                {
                    _estadosNotificaciones=new EstadoNotificacionRepository(_context);
                }
                return _estadosNotificaciones;
            }
        }

        public IFormato Formatos {
            get{
                if(_formatos==null)
                {
                    _formatos=new FormatoRepository(_context);
                }
                return _formatos;
            }
        }

        public IGenericossvSubModulos GenericossvSubsModulos {
            get{
                if(_genericossvSubsModulos==null)
                {
                    _genericossvSubsModulos=new GenericosvsSubModulosRepository(_context);
                }
                return _genericossvSubsModulos;
            }
        }

        public IMaestrosvSubModulos MaestrosvSubsModulos {
            get{
                if(_maestrosvSubsModulos==null)
                {
                    _maestrosvSubsModulos=new MaestrosvSubModulosRepository(_context);
                }
                return _maestrosvSubsModulos;
            }
        }

        public IModuloNotificacion ModulosNotificaciones {
            get{
                if(_modulosNotificaciones==null)
                {
                    _modulosNotificaciones=new ModuloNotificacionRepository(_context);
                }
                return _modulosNotificaciones;
            }
        }

        public IModulosMaestros ModuloMaestros {
            get{
                if(_moduloMaestros==null)
                {
                    _moduloMaestros=new ModulosMaestrosRepository(_context);
                }
                return _moduloMaestros;
            }
        }

        public IPermisosGenericos PermisoGenerico {
            get{
                if(_permisoGenerico==null)
                {
                    _permisoGenerico=new PermisosGenericosRepository(_context);
                }
                return _permisoGenerico;
            }
        }

        public IRadicado Radicados {
            get{
                if(_radicados==null)
                {
                    _radicados=new RadicadoRepository(_context);
                }
                return _radicados;
            }
        }

        public IRespuestaNotificacion RespuestasNotificaciones {
            get{
                if(_respuestasNotificaciones==null)
                {
                    _respuestasNotificaciones=new RespuestaNotificacionRepository(_context);
                }
                return _respuestasNotificaciones;
            }
        }

        public IRol Roles {
            get{
                if(_roles==null)
                {
                    _roles=new RolRepository(_context);
                }
                return _roles;
            }
        }

        public IRolvsMaestro RolsvsMaestros {
            get{
                if(_rolsvsMaestros==null)
                {
                    _rolsvsMaestros=new RolvsMaestroRepository(_context);
                }
                return _rolsvsMaestros;
            }
        }

        public ISubModulo SubsModulos {
            get{
                if(_subsModulos==null)
                {
                    _subsModulos=new SubModulosRepository(_context);
                }
                return _subsModulos;
            }
        }

        public ITipoNotificacion TiposNotificaciones {
            get{
                if(_tiposNotificaciones==null)
                {
                    _tiposNotificaciones=new TipoNotificacionRepository(_context);
                }
                return _tiposNotificaciones;
            }
        }

        public ITipoRequerimiento TiposRequerimientos {
            get{
                if(_tiposRequerimientos==null)
                {
                    _tiposRequerimientos=new TipoRequerimientoRepository(_context);
                }
                return _tiposRequerimientos;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public UnitOfWork(NotiContext context){
            _context = context;
        }

    }
}

