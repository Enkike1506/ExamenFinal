<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="ExamenFinal.Vistas.Empleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Empleados</h1>
    <br />
    <br />
    <div>
        <asp:GridView ID="GridViewEmpleados" runat="server"></asp:GridView>
    </div>
    <br />
    <br />
    <br />
    <div>
        Código del empleado:
        <asp:TextBox ID="tCodigo" Type="number" runat="server"></asp:TextBox>
        <br />
        Número de carné:
        <asp:TextBox ID="tCarne" Type="number" runat="server"></asp:TextBox>
        <br />
        Nombre del empleado:
        <asp:TextBox ID="tNombre" runat="server"></asp:TextBox>
        <br />
        Edad del empleado:
        <asp:TextBox ID="tEdad" Type="number" runat="server"></asp:TextBox>
        <br />
        Fecha de nacimiento del empleado:
        <asp:TextBox ID="tFechaNacimiento" Type="date" runat="server"></asp:TextBox>
        <br />
        Categoría del empleado:
        <asp:TextBox ID="tCategoria" runat="server"></asp:TextBox>
        <br />
        Salario del empleado:
        <asp:TextBox ID="tSalario" Type="number" runat="server"></asp:TextBox>
        <br />
        Dirección del empleado:
        <asp:TextBox ID="tDireccion" runat="server"></asp:TextBox>
        <br />
        Teléfono del empleado:
        <asp:TextBox ID="tTelefono" runat="server"></asp:TextBox>
        <br />
        Correo del empleado:
        <asp:TextBox ID="tCorreo" runat="server"></asp:TextBox>
        <br />
    </div>
    <br />
    <br />
    <div>
        <asp:Button ID="bAgregar" runat="server" Text="Agregar" />
        <asp:Button ID="bBorrar" runat="server" Text="Eliminar" />
        <asp:Button ID="bConsultar" runat="server" Text="Consultar" />
    </div>
</asp:Content>