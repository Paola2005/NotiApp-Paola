using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Rol:BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<GenericosvsSubModulos>GenericossvSubsModulos{get; set;}
        public ICollection<RolvsMaestro> RolsvsMaestros{get;set;}
    }
}