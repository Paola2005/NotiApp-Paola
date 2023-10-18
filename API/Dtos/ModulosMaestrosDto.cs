using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class ModulosMaestrosDto
    {
        public int Id { get; set; }
        public string NombreModulo { get; set; }
        public string MaestrosvSubModulos { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public List<RolvsMaestro> RolvsMaestros {get; set;}
        public List<MaestrosvSubModulos> MaestrosvsSubModulos {get; set;}

    }
}