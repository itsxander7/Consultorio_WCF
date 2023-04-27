<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="PL.Pantallas.Formularios.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3  ALIGN=center>
<br />
        Usuarios

     <p ALIGN=center> 
             Ingrese la informacion necesaria para poder agreagar un Usuario
         <br />
          <br />
         &nbsp;&nbsp; 
         <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre: "></asp:Label>&nbsp;&nbsp;
          <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
         &nbsp;&nbsp;
         <br />
          <br />
         &nbsp;&nbsp;
         <asp:Label ID="Label2" runat="server" Text="Ingrese el costo del servicio: "></asp:Label>&nbsp;&nbsp;
              <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
         <br />
          <br />
         &nbsp;&nbsp;

          <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnFiltar" runat="server" Text="Filtrar" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnEditar" runat="server" Text="Editar" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnBorrar" runat="server" Text="Borrar" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <br />
          <br />
         <asp:GridView ID="GridViewUsuarios" runat="server"></asp:GridView>
         </h3>
</asp:Content>
