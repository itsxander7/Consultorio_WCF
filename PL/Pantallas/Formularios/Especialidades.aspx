<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="PL.Pantallas.Formularios.Especialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 align="center">
        <asp:Label ID="Label1" runat="server" Text="Especialidades" Font-Names="Arial" Font-Bold="True" Font-Italic="True"></asp:Label>
        <br />

    </h3>
    <p align="center" style="font-family: sans-serif; color: rgba(110, 128, 122, 0.8);">
        <br>




        <br>
        <br>
        <asp:Label ID="Label2" runat="server" Text="ID Especialidad"></asp:Label>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtIdEspecialidad" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="155px" ></asp:TextBox>

        <br>
        <br>
        <br>


        <asp:Label ID="Label3" runat="server" Text="Nombre Especialidad"></asp:Label>

        &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtNombreEspecialidad" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="155px" ></asp:TextBox>
        <br>
        <br>
        <br>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtnInsertar" runat="server" Text="Insertar Nombre" Font-Names="Arial" ForeColor="Black" OnClick="BtnInsertar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnEditar" runat="server" Text="Editar por ID" Font-Names="Arial" OnClick="BtnEditar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar por ID" Font-Names="Arial" OnClick="BtnEliminar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar por Nombre" Font-Names="Arial" OnClick="BtnFiltrar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridViewEspecialidad" runat="server" HorizontalAlign="Center"></asp:GridView>

        
</asp:Content>
