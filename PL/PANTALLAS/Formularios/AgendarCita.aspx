<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseLogin.Master" AutoEventWireup="true" CodeBehind="AgendarCita.aspx.cs" Inherits="PL.Pantallas.Formularios.AgendarCita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link href="../../Recursos/css/SaludVida.css" rel="stylesheet" />
    <div>	
        <h1>	
		
        <br />Solicitud de cita médica
		<br />
        <br>
		<label for="doctor">Doctor:</label>
		<asp:TextBox ID="txtDoctor" runat="server"></asp:TextBox><br><br>
		<label for="especialidad">Especialidad:</label>
		<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br><br>
		<label for="cliente">Cliente:</label>
		<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br><br>
		<label for="servicio">Servicio:</label>
		<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br><br>
		<label for="fecha">Fecha de la cita:</label>
		<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br><br>
		<label for="servicio">Promocion:</label>
		<asp:ListBox runat="server" Height="30px" Width="200px">
        </asp:ListBox><br><br>
		<asp:Button runat="server" Text="Reservar Cita"></asp:Button><br><br>
		<br><br>
		</h1>
    </div>
		
		
</asp:Content>
