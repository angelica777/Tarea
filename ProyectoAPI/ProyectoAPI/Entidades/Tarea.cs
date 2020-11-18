using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAPI.Entidades
{
    public class Tarea
    {
        public string idTarea { get; set; }
        public string nombreTarea { get; set; }
        public string descripcion { get; set; }
        public string prioridad { get; set; }

        public string estado { get; set; }

        public string responsable { get; set; }

    }
}
