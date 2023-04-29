<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Facturas.aspx.cs" Inherits="PL.Pantallas.Formularios.Facturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center">
        <br />
        Facturación
    </h1>
    <p align="center">
        Información de la facturación.
         <br />
        <br />
        &nbsp;&nbsp;
               
            <asp:GridView ID="GridViewfactura" runat="server" HorizontalAlign="Center"></asp:GridView>

    </p>

</asp:Content>
