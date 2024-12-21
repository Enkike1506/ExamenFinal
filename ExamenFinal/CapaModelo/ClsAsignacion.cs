using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFinal.CapaModelo
{
    public class ClsAsignacion
    {
        public int Id {  get; set; }
        public int EmpleadoId { get; set; }
        public int ProyectoId {  get; set; }
        public string FechaAsignacion { get; set; }
    }
}