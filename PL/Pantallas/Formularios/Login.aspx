<%@ Page Title="" Language="C#" MasterPageFile="~/Pantallas/Maestras/BaseLogin.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PL.Pantallas.Formularios.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html><head>
        <title></title>
        <meta charset="utf-8">
        
       
        
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        
        <meta name="author" content="Videojuegos &amp; Desarrollo">
        <meta name="description" content="Muestra de un formulario de acceso en HTML y CSS">
        <meta name="keywords" content="Formulario Acceso, Formulario de LogIn">
        
        <link href="https://fonts.googleapis.com/css?family=Nunito&amp;display=swap" rel="stylesheet"> 
        <link href="https://fonts.googleapis.com/css?family=Overpass&amp;display=swap" rel="stylesheet">
        
        <!-- Link hacia el archivo de estilos css -->
       <link href="../../Recursos/css/Login.css" rel="stylesheet" />
        
        <style type="text/css">
            
        </style>
        
        <script type="text/javascript">
        
        </script>
        
    </head>
    
    <body>
        
        <div id="contenedor">
            <div id="central">
                <div id="login">
                    <div class="titulo">
                       &nbsp; Bienvenid@
                              </div>
                        <form id="loginform">
                        <input type="text" name="txt_Usuario" placeholder="Usuario" required="">
                        <br />  <br />
                        <input type="password" placeholder="Contraseña" name="txt_Password" required="">
                        <br />  <br />
                  <asp:Button ID="Button1" runat="server" Text="Login" Height="53px"/>
                    </form>
                    <div class="pie-form">
                        <a href="#">¿Perdiste tu contraseña?</a><br />
                        <a href="#">¿No tienes Cuenta? Registrate</a>
                    </div>
                </div>
                <div class="inferior">
                    <a href="../Formularios/Index.aspx">Volver</a>
                </div>
            </div>
        </div>
            
    
</body></html>
</asp:Content>
