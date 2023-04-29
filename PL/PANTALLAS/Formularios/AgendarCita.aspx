<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseLogin.Master" AutoEventWireup="true" CodeBehind="AgendarCita.aspx.cs" Inherits="PL.Pantallas.Formularios.AgendarCita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 ALIGN=center>
		Solicitud de cita médica
		<br>
		<label for="doctor">Doctor:</label>
		<input type="text" id="doctor" name="doctor"><br><br>

		<label for="especialidad">Especialidad:</label>
		<input type="text" id="especialidad" name="especialidad"><br><br>

		<label for="cliente">Cliente:</label>
		<input type="text" id="cliente" name="cliente"><br><br>

		<label for="servicio">Servicio:</label>
		<input type="text" id="servicio" name="servicio"><br><br>

		<label for="fecha">Fecha de la cita:</label>
		<input type="datetime-local" id="fecha" name="fecha"><br><br>

		<input type="submit" value="Reservar">

	</h1>
</asp:Content>
