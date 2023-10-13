using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MaestrosvSubModulos:BaseEntity
    {
        public int IdMaestro { get; set; }
        public ModulosMaestros ModuloMaestros{get; set;}
        public int IdSubModulo { get; set; }
        public SubModulos SubsModulos{get; set;}
        public ICollection<GenericosvsSubModulos>GenericosvSubsModulos{get; set;}
    }
}