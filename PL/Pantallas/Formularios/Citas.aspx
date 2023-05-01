<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Citas.aspx.cs" Inherits="PL.Pantallas.Formularios.Citas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Recursos/css/SaludVida.css" rel="stylesheet" />
   <div >
       <br />
       <p>Citas medicas</p>
       <h1> 
    <asp:Label ID="Label5" runat="server" Text="Numero de cita:"></asp:Label>
    <asp:TextBox ID="txtFiltrar" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="400px"></asp:TextBox><br><br>

    <asp:Label ID="Label1" runat="server" Text="Cedula del Cliente:"></asp:Label>&nbsp&nbsp;&nbsp&nbsp;
   <asp:DropDownList ID="ddl_Id_Cliente" runat="server" OnSelectedIndexChanged="ddl_SelectedIndexChanged" Style="margin-left: 7px; margin-top: 0;" Width="400px"></asp:DropDownList>
    <br />
    <br />
    &nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Especialidad: "></asp:Label>&nbsp&nbsp;&nbsp&nbsp;
    <asp:DropDownList ID="ddl_Nombre_Especialidad" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="400px"></asp:DropDownList>
    <br />
    <br />
    &nbsp;&nbsp;

    <asp:Label ID="Label3" runat="server" Text="Doctor:"></asp:Label>&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddl_Nombre_Doctor" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="400px"></asp:DropDownList>
    <br />
    <br />
    &nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Ingrese la fecha:"></asp:Label>&nbsp&nbsp;&nbsp&nbsp;
    <asp:TextBox ID="Txt_Fecha" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="400px" onkeydown="return ((event.keyCode >= 48 && event.keyCode <= 57) or event.keyCode == 127)" MaxLength="11" OnTextChanged="Txt_Fecha_TextChanged" TextMode="DateTime"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
    <asp:Button ID="btnFiltar" runat="server" Text="Filtrar" OnClick="btnFiltar_Click" />
    <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
    <br />
    <br />
    <asp:GridView ID="gdvCitas" runat="server" HorizontalAlign="Center" Height="31px" Width="409px"></asp:GridView>
    <br />
    <br />
</h1>
</div>
</asp:Content>
