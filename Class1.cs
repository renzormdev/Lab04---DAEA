using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva01
{
    public class Proveedor
    {
        public string idProveedor { get; set; }
        public string nombreCompañia { get; set; }
        public string nombrecontacto { get; set; }
        public string cargocontacto { get; set; }
        public string direccion { get; set; }

    }

    public class Categoria
    {
        public string idcategoria { get; set; }
        public string nombrecategoria { get; set; }
        public string descripcion { get; set; }
        public string Activo { get; set; }
        public string CodCategoria { get; set; }

    }
}
