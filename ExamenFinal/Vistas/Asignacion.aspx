<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Asignacion.aspx.cs" Inherits="ExamenFinal.Vistas.Asignacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Asignaciones</h1>
    <br />
    <br />
    <div>
        <asp:GridView ID="GridViewAsignaciones" runat="server"></asp:GridView>
    </div>
    <br />
    <br />
    <br />
    <div>
        Código de la asignación:
        <asp:TextBox ID="tCodigo" Type="number" runat="server"></asp:TextBox>
        <br />
        Código del empleado:
        <asp:TextBox ID="tCodigoEmpleado" Type="number" runat="server"></asp:TextBox>
        <br />
        Código del proyecto:
        <asp:TextBox ID="tCodigoProyecto" Type="number" runat="server"></asp:TextBox>
        <br />
        Fecha de la asignación:
        <asp:TextBox ID="tFechaAsignacion" Type="date" runat="server"></asp:TextBox>
    </div>
    <br />
    <br />
    <div>
        <asp:Button ID="bAgregar" runat="server" Text="Agregar" OnClick="bAgregar_Click" />
        <asp:Button ID="bBorrar" runat="server" Text="Eliminar" OnClick="bBorrar_Click" />
    </div>
</asp:Content>
