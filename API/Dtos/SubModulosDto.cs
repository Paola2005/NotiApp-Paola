using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class SubModulosDto
    {
        public int Id { get; set; }
        public string NombreSubModulo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public List<MaestrosvSubModulos> MaestrosvsSubModulos {get; set;}

    }
}