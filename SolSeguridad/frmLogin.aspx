<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="SolSeguridad.frmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<br />
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    <asp:ListItem>Seleccione Rol</asp:ListItem>
    <asp:ListItem>Medico</asp:ListItem>
    <asp:ListItem>Paciente</asp:ListItem>
</asp:DropDownList>
<br />
<asp:Login runat="server" ID ="Inicio" OnAuthenticate="Inicio_Authenticate"></asp:Login>
<br />
</asp:Content>
