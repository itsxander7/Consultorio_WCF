<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Doctores.aspx.cs" Inherits="PL.Pantallas.Formularios.Doctores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Recursos/css/SaludVida.css" rel="stylesheet" />
    <div>   
        <h1>
            <p>DOCTORES</p>
<asp:Label ID="Label1" runat="server" Text="ID del Doctor"></asp:Label>
<asp:TextBox ID="TxtIdDoctor" runat="server"></asp:TextBox>

<br><br>

<asp:Label ID="Label3" runat="server" Text="Especialidad"></asp:Label>
<asp:TextBox ID="TxtIdEspecialidad" runat="server"></asp:TextBox>

<br><br>

<asp:Label ID="Label4" runat="server" Text="Nombre"></asp:Label>
<asp:TextBox ID="TxtNombreDoctor" runat="server"></asp:TextBox>

<br><br>

<asp:Label ID="Label5" runat="server" Text="Apellido"></asp:Label>
<asp:TextBox ID="TxtApellido1Doctor" runat="server"></asp:TextBox>

<br><br>

<asp:Label ID="Label6" runat="server" Text="Apellido"></asp:Label>
<asp:TextBox ID="TxtApellido2Doctor" runat="server"></asp:TextBox>

<br><br>

<asp:Label ID="Label7" runat="server" Text="Telefono"></asp:Label>
<asp:TextBox ID="TxtTelefonoDoctor" runat="server"></asp:TextBox>

<br><br>

<asp:Label ID="Label8" runat="server" Text="Correo"></asp:Label>
<asp:TextBox ID="TxtCorreoDoctor" runat="server"></asp:TextBox>

<br><br><br>

<asp:Button ID="btnInsertar" runat="server" Text="Insertar" />

<asp:Button ID="btnEditar" runat="server" Text="Editar" />

<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />

<asp:Button ID="BtnMostrar" runat="server" Text="Mostrar" />

         </h1>

    </div>
</asp:Content>
