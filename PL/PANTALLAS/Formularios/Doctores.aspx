<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Doctores.aspx.cs" Inherits="PL.Pantallas.Formularios.Doctores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Label ID="Label2" runat="server" Text="Doctores" Font-Bold="True" Font-Italic="True" Font-Names="Arial"></asp:Label>

    <br><br><br>
    <asp:Label ID="Label1" runat="server" Text="ID Doctor"></asp:Label>
   
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtIdDoctor" runat="server" Font-Bold="False" Width="114px"></asp:TextBox>
    
    <br><br>
    
    &nbsp;<asp:Label ID="Label3" runat="server" Text="ID Especialidad"></asp:Label>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtIdEspecialidad" runat="server" style="margin-left: 14px" Width="118px"></asp:TextBox>
   
    <br><br>

    <asp:Label ID="Label4" runat="server" Text="Nombre Doctor"></asp:Label>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtNombreDoctor" runat="server" Width="120px"></asp:TextBox>
    <br><br>


    <asp:Label ID="Label5" runat="server" Text="Apellido1 Doctor"></asp:Label>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
    <asp:TextBox ID="TxtApellido1Doctor" runat="server"></asp:TextBox>
    <br><br>


    <asp:Label ID="Label6" runat="server" Text="Apellido2 Doctor"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtApellido2Doctor" runat="server"></asp:TextBox>

    <br><br>

    <asp:Label ID="Label7" runat="server" Text="Telefono Doctor"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtTelefonoDoctor" runat="server"></asp:TextBox>
    <br><br>


    <asp:Label ID="Label8" runat="server" Text="Correo Doctor"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtCorreoDoctor" runat="server"></asp:TextBox>
    <br><br>


    <asp:Label ID="Label9" runat="server" Text="ID Usuario"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtIdUsuario" runat="server" Width="123px"></asp:TextBox>

    <br><br><br>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


    <asp:Button ID="btnInsertar" runat="server" Text="Insertar" Font-Names="Arial" Font-Overline="False" Font-Size="Small" Font-Strikeout="False" Font-Underline="False" ForeColor="Black" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnEditar" runat="server" Text="Editar" Font-Names="Arial" ForeColor="Black" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Font-Names="Arial" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <%--<asp:Button ID="BtnFiltrar" runat="server" Text="Filtrar" Font-Names="Arial" OnClick="Button4_Click" />--%>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


            <asp:Button ID="BtnMostrar" runat="server" Text="Mostrar" />


</asp:Content>
