<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="PL.Pantallas.Formularios.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Recursos/css/SaludVida.css" rel="stylesheet" />
	<div> 
     <p>Clientes</p>
        <h1>
       
           <asp:Label ID="Label8" runat="server" Text="ID Cliente:"></asp:Label>
           <asp:TextBox ID="txt_IdCliente" runat="server" Style="margin-left: 7px;"></asp:TextBox><br><br>
           <asp:Label ID="Label1" runat="server" Text="Nombre del cliente:"></asp:Label>
           <asp:TextBox ID="txt_NombreCliente" runat="server" Style="margin-left: 7px;"></asp:TextBox><br><br>
           <asp:Label ID="Label2" runat="server" Text="Primer apellido:"></asp:Label>
           <asp:TextBox ID="txt_PrimerApellido" runat="server" Style="margin-left: 7px;"></asp:TextBox><br><br> 
           <asp:Label ID="Label3" runat="server" Text="Segundo apellido:"></asp:Label>
           <asp:TextBox ID="txt_SegundoApellido" runat="server" Style="margin-left: 7px;"></asp:TextBox><br><br> 
           <asp:Label ID="Label4" runat="server" Text="Direccion:"></asp:Label>
           <asp:TextBox ID="txt_Direccion" runat="server" Style="margin-left: 7px;"></asp:TextBox><br><br> 
           <asp:Label ID="Label5" runat="server" Text="Telefono:"></asp:Label>
           <asp:TextBox ID="txt_Telefono" runat="server" Style="margin-left: 7px;"></asp:TextBox><br><br> 
           <asp:Label ID="Label9" runat="server" Text="Correo:"></asp:Label>
           <asp:TextBox ID="txt_Correo" runat="server" Style="margin-left: 7px;"></asp:TextBox><br><br> 
           <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
           <asp:Button ID="btnFiltar" runat="server" Text="Filtrar" OnClick="btnFiltar_Click" />
           <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
           <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" /><br><br>
           <asp:GridView ID="dgvClientes" runat="server" HorizontalAlign="Center" Height="31px" Width="409px"></asp:GridView>
           <br><br> 
            
           
      
   
</asp:Content>
