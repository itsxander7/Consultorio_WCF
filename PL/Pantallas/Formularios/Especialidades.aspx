<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="PL.Pantallas.Formularios.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3  ALIGN=center>
<br />
       

     <p ALIGN=center> 
    <br>
    
    
    <asp:Label ID="Label1" runat="server" Text="Especialidades" Font-Names="Arial" Font-Bold="True" Font-Italic="True"></asp:Label>

    <br><br>
    <asp:Label ID="Label2" runat="server" Text="ID Especialidad"></asp:Label>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtIdEspecialidad" runat="server" style="margin-left: 7px; margin-top: 0;" Width="155px"></asp:TextBox>

    <br><br><br>

    
    <asp:Label ID="Label3" runat="server" Text="Nombre Especialidad"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtNombreEspecialidad" runat="server" style="margin-left: 7px; margin-top: 0;" Width="155px"></asp:TextBox>
    <br><br><br>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtnInsertar" runat="server" Text="Insertar" Font-Names="Arial" ForeColor="Black" OnClick="BtnInsertar_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnEditar" runat="server" Text="Editar" Font-Names="Arial" OnClick="BtnEditar_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" Font-Names="Arial" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar" Font-Names="Arial" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnMostrar" runat="server" Font-Names="Arial" Text="Mostrar" />

</h3>

</asp:Content>
