<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Facturas.aspx.cs" Inherits="PL.Pantallas.Formularios.Facturas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Recursos/css/SaludVida.css" rel="stylesheet" />

    <h1>
        <div style="font-family: sans-serif; color: rgba(110, 128, 122, 0.8); font-size: 16px; text-align: center">
            <br>
            <br>
            <br>


            <p style="font-weight: bold">
                INFORMACION DE FACTURACION
            </p>

            <br>
            <br>
            <br>
            <asp:Label ID="lFiltro" runat="server" Text="Filtrar por Cedula:"></asp:Label>&nbsp&nbsp;&nbsp&nbsp
            <asp:DropDownList ID="ddl_Filtrar" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="400px" BorderColor="#CCCCCC"></asp:DropDownList>
            <asp:Button ID="btn_Filtrar" runat="server" Text="Filtrar" BackColor="#00FFCC" BorderColor="#00FFCC" ForeColor="#666666" OnClick="btn_Filtrar_Click"/>
            <br>
            <br>
            <br>
            <asp:GridView ID="GridViewfactura" runat="server" HorizontalAlign="Center"></asp:GridView>

            <br>
            <br>
            <br>
        </div>




    </h1>
</asp:Content>
