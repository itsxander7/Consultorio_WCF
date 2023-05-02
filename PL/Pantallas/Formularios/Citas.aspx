<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseMantenimientos.Master" AutoEventWireup="true" CodeBehind="Citas.aspx.cs" Inherits="PL.Pantallas.Formularios.Citas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Recursos/css/SaludVida.css" rel="stylesheet" />
    <h1>
        <div style="font-family: sans-serif; color: rgba(110, 128, 122, 0.8); font-size: 16px">

            <br />
            <strong>
                <p >Citas medicas</p>
            </strong>
            <asp:Label ID="filtrar" runat="server" Text="Filtrar por Cita"></asp:Label>
            <asp:TextBox ID="txt_Filtrar" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="400px" TextMode="Number" BorderColor="#CCCCCC"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Filtrar" OnClick="btnFiltar_Click" BackColor="#00FFCC" BorderColor="#00FFCC" ForeColor="#666666" />&nbsp
            <asp:HyperLink ID="HyperLink1" runat="server" onclick="toggle()" ForeColor="#00CC99">Editar</asp:HyperLink>
            &nbsp;&nbsp;
            <br />
            <br />

            <div id="div_Editar" style="display: none">
                &nbsp;&nbsp
                <br />
                <br />
                <asp:Label ID="id" runat="server" Text="Numero de Cita:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp&nbsp&nbsp;&nbsp;&nbsp
                <asp:TextBox ID="txt_Numero_Citas" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="400px" TextMode="Number" BorderColor="#CCCCCC" Font-Size="Medium" Enabled="False"></asp:TextBox>
                &nbsp;&nbsp
            <br />
                <asp:LinkButton ID="lb_Habilitar" runat="server" OnClick="lb_Habilitar_Click">Habilitar para Editar o Borrar</asp:LinkButton>
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Cedula del Cliente:"></asp:Label>&nbsp&nbsp;&nbsp&nbsp
                <asp:DropDownList ID="ddl_Id_Cliente" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="400px" BorderColor="#CCCCCC" Font-Size="Medium"></asp:DropDownList>
                <br />
                <br />
                &nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Especialidad: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                <asp:DropDownList ID="ddl_Nombre_Especialidad" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="400px" BorderColor="#CCCCCC" Font-Size="Medium"></asp:DropDownList>
                <br />
                <br />
                &nbsp;&nbsp;

                <asp:Label ID="Label3" runat="server" Text="Doctor:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                <asp:DropDownList ID="ddl_Nombre_Doctor" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="400px" BorderColor="#CCCCCC" Font-Size="Medium"></asp:DropDownList>
                <br />
                <br />
                &nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Ingrese la fecha:"></asp:Label>&nbsp&nbsp;&nbsp&nbsp;&nbsp
                <asp:TextBox ID="Txt_Fecha" runat="server" Style="margin-left: 7px; margin-top: 0;" Width="400px" TextMode="Date" BorderColor="#CCCCCC" Font-Size="Medium"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" BackColor="#00FFCC" BorderColor="#00FFCC" ForeColor="#666666" />
                <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" BackColor="#00FFCC" BorderColor="#00FFCC" ForeColor="#666666" />
                <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" BackColor="#00FFCC" BorderColor="#00FFCC" ForeColor="#666666" />

            </div>
            <br />
            <br />

            <asp:GridView ID="gdvCitas" runat="server" HorizontalAlign="Center" Height="31px" Width="409px" BorderColor="#CCCCCC"></asp:GridView>

            <br />
            <br />

        </div>
    </h1>
    <script>

        function toggle() {

            var ele = document.getElementById("div_Editar");

            if (ele.style.display == "block") {

                ele.style.display = "none";
            }
            else {

                ele.style.display = "block";
            }
        }

    </script>
</asp:Content>
