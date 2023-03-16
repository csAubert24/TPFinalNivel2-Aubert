using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;





namespace Dominio
{
    public class Articulo
    {
        [DisplayName("Codigo")]
        public string codigo { get; set; }
        [DisplayName("Nmbre")]
        public string nombre { get; set; }
        [DisplayName("Descripcíon")]
        public string descripcion { get; set; }
        public string Url { get; set; }
            [DisplayName("Marca")]
            public elemento  marca{ get; set; }
            [DisplayName("Categoría")]
            public elemento categoria { get; set; }
            [DisplayName("Precio")]
            public Decimal precio { get; set; }   


    }
}
