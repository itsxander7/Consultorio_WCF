<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Doctores.aspx.cs" Inherits="PL.Pantallas.Formularios.Doctores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Recursos/css/SaludVida.css" rel="stylesheet" />
    <br /> <p>DOCTORES</p>
    <div>
        <h1>
           
    <asp:Label ID="Label1" runat="server" Text="ID Doctor:"></asp:Label>&nbsp;&nbsp;
    <asp:TextBox ID="TxtIdDoctor" onkeypress="return justNumbers(event);" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label10" runat="server" Text="Cedula:"></asp:Label>
    <asp:TextBox ID="txtCedula" onkeypress="return justNumbers(event);" runat="server"></asp:TextBox><br><br>
    <asp:Label ID="Label3" runat="server" Text="Especialidad:"></asp:Label>&nbsp;&nbsp;
    <asp:DropDownList runat="server" ID="cmbEspecialidad"></asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Nombre:"></asp:Label>&nbsp;&nbsp;
    <asp:TextBox ID="TxtNombreDoctor" onkeypress="return soloLetras(event);"  runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label5" runat="server" Text="Primer Apellido:"></asp:Label>&nbsp;&nbsp;
    <asp:TextBox ID="TxtApellido1Doctor" onkeypress="return soloLetras(event);" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Segundo Apellido:"></asp:Label>&nbsp;&nbsp;
    <asp:TextBox ID="TxtApellido2Doctor" onkeypress="return soloLetras(event);" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label7" runat="server" Text="Telefono:"></asp:Label>&nbsp;&nbsp;
    <asp:TextBox ID="TxtTelefonoDoctor" onkeypress="return justNumbers(event);" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label8" runat="server" Text="Correo:"></asp:Label>&nbsp;&nbsp;
    <asp:TextBox ID="TxtCorreoDoctor" onkeypress="return justNumbers(event);" runat="server"></asp:TextBox>&nbsp;&nbsp;
    <br /><br />
    <asp:Label ID="Label9" runat="server" Text="ID Usuario:"></asp:Label>&nbsp;&nbsp;
    <asp:DropDownList runat="server" ID="cmbUsuario"></asp:DropDownList>
    <br /><br />
    <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click1" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" /><br /><br />
    <asp:TextBox runat="server" ID="txtBuscarDoctor" onkeypress="return justNumbers(event);" ></asp:TextBox> &nbsp;&nbsp;
    <asp:Button ID="BtnMostrar" runat="server" Text="Mostrar" OnClick="BtnMostrar_Click" /> <br /><br />
    <asp:GridView ID="dgvDoctores" runat="server" HorizontalAlign="Center" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
 </h1>
        </div>
</asp:Content>
