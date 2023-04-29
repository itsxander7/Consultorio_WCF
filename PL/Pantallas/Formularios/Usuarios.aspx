<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="PL.Pantallas.Formularios.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center">
        <br />
        Usuarios
    </h1>
    <p align="center" style="font-family: sans-serif; color: rgba(110, 128, 122, 0.8);">
        Ingrese la informacion necesaria para poder agreagar un Usuario
         <br />
        <br />
        &nbsp;&nbsp;
         <asp:Label ID="Label4" runat="server" Text="ID Usuario"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="Txt_Filtrar" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="155px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp; 
         <asp:Label ID="Label1" runat="server" Text="Ingrese o Filtre el nombre: "></asp:Label>&nbsp;&nbsp;
          <asp:TextBox ID="txtNombre" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="155px"></asp:TextBox>
        &nbsp;&nbsp;
         <br />
        <br />
        &nbsp;&nbsp;
         <asp:Label ID="Label2" runat="server" Text="Ingrese contraseña "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Style="margin-left: 7px; margin-top: 0;" Width="155px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;

          <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnFiltar" runat="server" Text="Filtrar" OnClick="btnFiltar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <br />
        <br />
        <asp:GridView ID="GridViewUsuarios" runat="server" HorizontalAlign="Center"></asp:GridView>


</asp:Content>
