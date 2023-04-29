<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Promociones.aspx.cs" Inherits="PL.Pantallas.Formularios.Promociones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Recursos/css/Clientes.css" rel="stylesheet" />
	
		<div id ="contenedor">
			<div id ="cabecera"></div>
			<div id ="menu"></div>
			<div id ="izquierda">
				     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;     
    <asp:Label ID="Label1" runat="server" Text="Mantenimineto Promociones" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black"></asp:Label>
    <br /><br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:Label ID="Label5" runat="server" Text="ID Promocion" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" Font-Size="Small"></asp:Label>
    <br />
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:TextBox ID="txt_IdPromocion" runat="server"></asp:TextBox>
     <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:Label ID="Label2" runat="server" Text="Detalle" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" Font-Size="Small"></asp:Label>
    <br />
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:TextBox ID="txt_Detalle" runat="server"></asp:TextBox>
     <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:Label ID="Label3" runat="server" Text="Monto de promocion" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" Font-Size="Small"></asp:Label>
    <br />
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:TextBox ID="txt_Monto" runat="server"></asp:TextBox>
     <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
    <asp:Label ID="Label4" runat="server" Text="Servicio" Font-Bold="True" Font-Names="Segoe UI" ForeColor="Black" Font-Size="Small"></asp:Label>
    <br />
                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="txt_Servicio" runat="server"></asp:TextBox>
    <br /><br />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Button ID="btn_Agregar" runat="server" Text="Agregar" BackColor="#CCCCCC" ForeColor="Black" Width="100px" OnClick="btn_Agregar_Click" /> &nbsp;<asp:Button ID="btn_modificar" runat="server" Text="Modificar" BackColor="#CCCCCC" Width="112px" OnClick="btn_modificar_Click" /> 
                     <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" BackColor="#CCCCCC" Height="35px" Width="99px" OnClick="btn_eliminar_Click" />

			&nbsp;<asp:Button ID="btn_Mostrar" runat="server" BackColor="#CCCCCC" OnClick="Button1_Click" Text="Filtrar" Width="112px" />

			</div> 
			<div id ="derecha">
                <br />
            &nbsp; &nbsp; &nbsp;
            <asp:GridView ID="GridView1" runat="server" BackColor="White"></asp:GridView>
			</div>
			<div id ="pie"></div>
		</div>

</asp:Content>
