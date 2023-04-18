<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PL._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CONSUMO WCF PROYECTO</h1>
        <p class="lead">Esta funcionalidad consume el servicio WCF del proyecto para la tabla de regiones.</p>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Buscar: "></asp:Label> 
            &nbsp;
            &nbsp;
            <asp:TextBox ID="txt_filtro" runat="server" Height="31px" Width="375px" OnTextChanged="txt_filtro_TextChanged"></asp:TextBox>
            &nbsp;
            &nbsp;
            <asp:Button ID="btn_filtrar" runat="server" Text="Aplicar Filtro" OnClick="btn_filtrar_Click" />
            &nbsp;
            &nbsp;
            <input id="btn_editar" type="button" value="Habilitar Edición"  onclick="toggle()"/>
        </div>
        <br />
        <div>
            <div id="div_Editar" class="jumbotron" style="display:block">
                <p class="lead">Edición de Datos de Regiones.</p>
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Nombre Cliente: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_nombreCliente" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    &nbsp;
                    &nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Primer Apellido Cliente: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_apellido1" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Segundo Apellido: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_apellido2" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                     <asp:Label ID="Label5" runat="server" Text="Dirección: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_direccion" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                    &nbsp;
                    <br />
                    <br />
                     <asp:Label ID="Label6" runat="server" Text="Telefono: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_telefono" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                    &nbsp;
                     <br />
                    <br />
                     <asp:Label ID="Label7" runat="server" Text="Correo: "></asp:Label> 
                    &nbsp;
                    <asp:TextBox ID="txt_correo" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                    <div style="text-align:center">
                        <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" OnClick="btn_Guardar_Click"  />
                        &nbsp;
                        &nbsp;
                        <asp:Button ID="txt_Eliminar" runat="server" Text="Eliminar" OnClick="txt_Eliminar_Click"/>
                    </div>
                   
                </div>
                <br />
        
            </div>

            <p>
                <asp:GridView ID="dgv_regiones" runat="server"></asp:GridView>
            </p>
        </div>
    </div>
    
    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

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
