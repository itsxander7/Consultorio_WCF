<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="PL.Pantallas.Formularios.Especialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Recursos/css/SaludVida.css" rel="stylesheet" />
    <div>
        <p>Especialidades</p>
        <h1>
        <asp:Label ID="Label2" runat="server" Text="ID Especialidad: "></asp:Label>
        <asp:DropDownList runat="server" ID="cmbEspecialidad" Width="168px"></asp:DropDownList><br><br>
        <asp:Label ID="Label3" runat="server" Text="Nombre Especialidad: "></asp:Label>
        <asp:TextBox ID="TxtNombreEspecialidad" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="155px"></asp:TextBox><br><br>
        <asp:Button ID="BtnInsertar" runat="server" Text="Insertar" Font-Names="Arial" ForeColor="Black" OnClick="BtnInsertar_Click" />
        <asp:Button ID="BtnEditar" runat="server" Text="Editar" Font-Names="Arial" OnClick="BtnEditar_Click" />
        <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" Font-Names="Arial" OnClick="BtnEliminar_Click" />
        <asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar" Font-Names="Arial" OnClick="BtnFiltrar_Click" />
        <br><br>
        <asp:GridView ID="GridViewEspecialidad" runat="server" HorizontalAlign="Center"></asp:GridView>
        </h1>
        </div>  
</asp:Content>
