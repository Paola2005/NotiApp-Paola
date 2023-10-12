using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class GenericosvsSubModulos:BaseEntity
    {
        public int IdGenericos { get; set; }
        public int IdSubModulos { get; set; }
        public int IdRol { get; set; }
    }
}