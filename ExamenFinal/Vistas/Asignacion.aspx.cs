using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamenFinal.CapaLogica;
using ExamenFinal.CapaModelo;

namespace ExamenFinal.Vistas
{
    public partial class Asignacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            List<ClsAsignacion> asignaciones = Asignaciones.ObtenerAsignaciones();

            GridViewAsignaciones.DataSource = asignaciones;
            GridViewAsignaciones.DataBind();
        }

        protected void bAgregar_Click(object sender, EventArgs e)
        {
            if(Asignaciones.AgregarAsignaciones(int.Parse(tCodigoEmpleado.Text), int.Parse(tCodigoProyecto.Text), tFechaAsignacion.Text) > 0)
            {
                DBConn.JavaScriptHelper.MostrarAlerta(this, "Asignación ingresada correctamente");
                LlenarGrid();
            }
            else
            {
                DBConn.JavaScriptHelper.MostrarAlerta(this, "Error al ingresar la asignación");
            }
        }

        protected void bBorrar_Click(object sender, EventArgs e)
        {
            if (Asignaciones.AgregarAsignaciones(int.Parse(tCodigoEmpleado.Text), int.Parse(tCodigoProyecto.Text), tFechaAsignacion.Text) > 0)
            {
                DBConn.JavaScriptHelper.MostrarAlerta(this, "Asignación eliminada correctamente");
                LlenarGrid();
            }
            else
            {
                DBConn.JavaScriptHelper.MostrarAlerta(this, "Error al eliminar la asignación");
            }
        }
    }
}