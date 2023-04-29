<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="PL.Pantallas.Formularios.Roles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h2  ALIGN=center>
     <br />
     

         ROLES<br><br>ID ROL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtIdRol" runat="server" Font-Bold="False" Width="114px"></asp:TextBox>
    
    <br><br>
    
    &nbsp;TIPO DE ROL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtTipoRol" runat="server" style="margin-left: 14px" Width="118px"></asp:TextBox>
   
    <br><br><br>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


    <asp:Button ID="btnInsertar" runat="server" Text="Insertar" Font-Names="Arial" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="Black" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnEditar" runat="server" Text="Editar" Font-Names="Arial" ForeColor="Black" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Font-Names="Arial" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <%--<asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar" Font-Names="Arial" OnClick="Button4_Click" />--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


            <asp:Button ID="BtnMostrar" runat="server" Text="Mostrar" />

         </h2>



</asp:Content>
