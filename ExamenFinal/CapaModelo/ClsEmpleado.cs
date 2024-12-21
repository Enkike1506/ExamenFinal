using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFinal.CapaModelo
{
    public class ClsEmpleado
    {
        public int Id { get; set; }
        public int Carne { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string FechaNacimiento { get; set; }
        public string Categoria { get; set; }
        public int Salario { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}