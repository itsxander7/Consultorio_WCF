<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="PL.Pantallas.Formularios.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 	<link href="../../Recursos/css/Clientes.css" rel="stylesheet" />
	
		<div id ="contenedor">
			<div id ="cabecera"></div>
			<div id ="menu"></div>
			<div id ="izquierda">
				     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;     
    <asp:Label ID="Label1" runat="server" Text="Mantenimiento Clientes" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label>
    <br /><br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:Label ID="Label2" runat="server" Text="Nombre del cliente" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" Font-Size="Small"></asp:Label>
    <br />
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:TextBox ID="txt_NombreCliente" runat="server"></asp:TextBox>
     <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:Label ID="Label3" runat="server" Text="Primer apellido" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" Font-Size="Small"></asp:Label>
    <br />
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:TextBox ID="txt_PrimerApellido" runat="server"></asp:TextBox>
     <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:Label ID="Label4" runat="server" Text="Segundo apellido" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" Font-Size="Small"></asp:Label>
    <br />
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:TextBox ID="txt_SegundoApellido" runat="server"></asp:TextBox>
     <br /> 
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:Label ID="Label5" runat="server" Text="Direccion " Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" Font-Size="Small"></asp:Label>
    <br />
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:TextBox ID="txt_Direccion" runat="server"></asp:TextBox>
    <br /> 
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:Label ID="Label6" runat="server" Text="Telefono" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" Font-Size="Small"></asp:Label>
    <br />
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:TextBox ID="txt_Telefono" runat="server"></asp:TextBox>
   
    <br /> 
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:Label ID="Label7" runat="server" Text="Correo" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" Font-Size="Small"></asp:Label>
    <br />
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:TextBox ID="txt_Correo" runat="server"></asp:TextBox>
    <br /><br />
             &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  <asp:Button ID="btn_Agregar" runat="server" Text="Agregar" BackColor="#CCCCCC" ForeColor="Black" Width="100px" /> &nbsp; <asp:Button ID="btn_modificar" runat="server" Text="Modificar" BackColor="#CCCCCC" Width="100px" /> &nbsp; <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" BackColor="#CCCCCC" Height="35px" Width="99px" />

			</div> 
			<div id ="derecha">
                <br />
            &nbsp; &nbsp; &nbsp;
            <asp:GridView ID="GridView1" runat="server" BackColor="White"></asp:GridView>
                <asp:TextBox ID="TextBox1" runat="server" BackColor="Yellow"></asp:TextBox>
			</div>
			<div id ="pie"></div>
		</div>

    
</asp:Content>
