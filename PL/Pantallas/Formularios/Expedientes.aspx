<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Expedientes.aspx.cs" Inherits="PL.Pantallas.Formularios.Expedientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1  ALIGN=center>
<br />
        Expedientes
</h1>
     <p ALIGN=center> 
             Ingrese la informacion necesaria para poder agregar el Expediente
         <br />
             <br />
         &nbsp;&nbsp;
         <asp:Label ID="Label1" runat="server" Text="Seleccione el ID del Cliente: "></asp:Label>&nbsp;&nbsp;
         <asp:DropDownList ID="DropDownListCliente" runat="server"></asp:DropDownList>
         <br />
          <br />
         &nbsp;&nbsp;
         <asp:Label ID="Label2" runat="server" Text="Ingrese el Detelle del detalle del expediente: "></asp:Label>&nbsp;&nbsp;
              <asp:TextBox ID="txtDetalle" runat="server"></asp:TextBox>
         <br />
          <br />
         &nbsp;&nbsp;
         <asp:Label ID="Label3" runat="server" Text="Seleccione el ID del Doctor "></asp:Label>&nbsp;&nbsp;
              <asp:DropDownList ID="DropDownDoctor" runat="server"></asp:DropDownList>
         <br />
          <br />
         &nbsp;&nbsp;
          <asp:Button ID="btnAgregar" runat="server" Text="Agreagar" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnFiltar" runat="server" Text="Filtrar" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnEditar" runat="server" Text="Editar" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnBorrar" runat="server" Text="Borrar" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <br />
          <br />
         <asp:GridView ID="GridViewExpedientes" runat="server"></asp:GridView>
</asp:Content>
