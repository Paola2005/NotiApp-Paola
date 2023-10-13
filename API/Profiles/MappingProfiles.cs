using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Auditoria, AuditoriaDto>().ReverseMap();
            CreateMap<BlockChain, BlockChainDto>().ReverseMap();
            CreateMap<EstadoNotificacion, EstadoNotificacionDto>().ReverseMap();
            CreateMap<Formato, FormatoDto>().ReverseMap();
            CreateMap<GenericosvsSubModulos, GenericosvSubModulosDto>().ReverseMap();
            CreateMap<MaestrosvSubModulos, MaestrosvSubModulosDto>().ReverseMap();
            CreateMap<ModuloNotificacion, ModuloNotificacionDto>().ReverseMap();
            CreateMap<ModulosMaestros, ModulosMaestrosDto>().ReverseMap();
            CreateMap<PermisosGenericos, PermisosGenericosDto>().ReverseMap();
            CreateMap<Radicado, RadicadoDto>().ReverseMap();
            CreateMap<RespuestaNotificacion, RespuestaNotificacionDto>().ReverseMap();
            CreateMap<Rol, RolDto>().ReverseMap();
            CreateMap<RolvsMaestro, RolvsMaestrosDto>().ReverseMap();
            CreateMap<SubModulos, SubModulosDto>().ReverseMap();
            CreateMap<TipoNotificacion, TipoNotificacionDto>().ReverseMap();
            CreateMap<TipoRequerimiento, TipoRequerimientoDto>().ReverseMap();

        }

    }
}