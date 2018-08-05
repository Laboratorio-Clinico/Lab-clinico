using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioClinico.Resources
{
    class Examen
    {
        public Int32 iIdExamen { get; set; }
        public string sDescripcion{ get; set; }

        public double fPrecio { get; set; }

        public Examen() { }

        public Examen(Int32 iIdexamenes, string sNombre, double dPrecioExamen) {

            this.iIdExamen = iIdexamenes;
            this.sDescripcion = sNombre;
            this.fPrecio = dPrecioExamen;
        }

    
    }

   
}
