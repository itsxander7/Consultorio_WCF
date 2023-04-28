<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Citas.aspx.cs" Inherits="PL.Pantallas.Formularios.Citas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h1  ALIGN=center>
<br />
        Citas
</h1>
     <p ALIGN=center> 
             Ingrese la informacion necesaria para poder agendar la cita
         <br />
          <br />
         &nbsp;&nbsp;
         <asp:Label ID="Label1" runat="server" Text="Seleccione el ID del Cliente: "></asp:Label>&nbsp;&nbsp;
         <asp:DropDownList ID="DropDownListCliente" runat="server"></asp:DropDownList>
         <br />
          <br />
         &nbsp;&nbsp;
         <asp:Label ID="Label2" runat="server" Text="Seleccione el ID de la Especializad: "></asp:Label>&nbsp;&nbsp;
              <asp:DropDownList ID="DropDownListEspecialidad" runat="server"></asp:DropDownList>
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
         <asp:GridView ID="GridViewCitas" runat="server"></asp:GridView>
         
</p>  


</asp:Content>
