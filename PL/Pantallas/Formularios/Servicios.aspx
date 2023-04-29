<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Servicios.aspx.cs" Inherits="PL.Pantallas.Formularios.Servicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1  ALIGN=center>
<br />
        Servicio
</h1>
     <p ALIGN=center> 
             Ingrese la informacion necesaria para poder agreagar un servicio
         <br />
          <br />
         &nbsp;&nbsp;
         <asp:Label ID="Label1" runat="server" Text="Seleccione el ID de la Especialidad: "></asp:Label>&nbsp;&nbsp;
         <asp:TextBox ID="txtIdespecialidad" runat="server"></asp:TextBox>
         <br />
          <br />
         &nbsp;&nbsp;
         <asp:Label ID="Label2" runat="server" Text="Ingrese el costo del servicio: "></asp:Label>&nbsp;&nbsp;
              <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox>
         <br />
          <br />
         &nbsp;&nbsp;
         <asp:Label ID="Label3" runat="server" Text="Ingrese el detalle del servicio:  "></asp:Label>&nbsp;&nbsp;
             <asp:TextBox ID="txtDetalle" runat="server"></asp:TextBox>
         <br />
          <br />
         &nbsp;&nbsp;
          <asp:Button ID="btnAgregar" runat="server" Text="Agreagar" OnClick="btnAgregar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnFiltar" runat="server" Text="Filtrar" OnClick="btnFiltar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <br />
          <br />
         <asp:GridView ID="GridViewServicios" runat="server"></asp:GridView>

</asp:Content>
