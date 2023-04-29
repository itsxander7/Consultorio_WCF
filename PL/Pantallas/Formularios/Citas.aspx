<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Citas.aspx.cs" Inherits="PL.Pantallas.Formularios.Citas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center">
        <br />
        Citas
    </h1>
    <p align="center" style="font-family: sans-serif; color: rgba(110, 128, 122, 0.8);">
        Ingrese la informacion necesaria para poder agendar la cita
         <br />
        <br />
        &nbsp;&nbsp;
         
         <asp:Label ID="Label5" runat="server" Text="Filtrar por Id Cita:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="Txt_Filtrar" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="155px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
         <asp:Label ID="Label1" runat="server" Text="Ingrese el ID del Cliente: "></asp:Label>&nbsp
         <asp:TextBox ID="Txt_Cliente" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="155px" onkeydown="return ((event.keyCode >= 48 && event.keyCode <= 57) or event.keyCode == 127)" MaxLength="11"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
         <asp:Label ID="Label2" runat="server" Text="Ingrese el ID de la Especialidad: "></asp:Label>
        <asp:TextBox ID="Txt_Especialidad" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="155px" onkeydown="return ((event.keyCode >= 48 && event.keyCode <= 57) or event.keyCode == 127)" MaxLength="11"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
         <asp:Label ID="Label3" runat="server" Text="Ingrese el ID del Doctor "></asp:Label>&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="Txt_Doctor" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="155px" onkeydown="return ((event.keyCode >= 48 && event.keyCode <= 57) or event.keyCode == 127)" MaxLength="11"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
          <asp:Label ID="Label4" runat="server" Text="Ingrese la fecha "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:TextBox ID="Txt_Fecha" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="155px" onkeydown="return ((event.keyCode >= 48 && event.keyCode <= 57) or event.keyCode == 127)" MaxLength="11"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
          <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnFiltar" runat="server" Text="Filtrar" OnClick="btnFiltar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <br />
        <br />

        <asp:GridView ID="GridViewCitas" runat="server" HorizontalAlign="Center"></asp:GridView>

    </p>


</asp:Content>
