using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace dominio
{

    public class Articulo


    {
        public int id { get; set; }


        [DisplayName ("Código")]
        public string codigo { get; set; }

        [DisplayName ("Nombre")]
        
        public string nombre { get; set; }
        [DisplayName("Descripción")]
        public string descrpcion { get; set; }
        
        public string Imagen { get; set; }
        [DisplayName("Marca")]
        public elemento marca { get; set; }
        [DisplayName("Categoría")]
        public elemento categoria { get; set; }
        [DisplayName("Precio")]
         public decimal precio { get; set; } 
    }
}