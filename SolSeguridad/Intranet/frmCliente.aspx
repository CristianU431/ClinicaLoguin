<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Intranet.Master" AutoEventWireup="true" CodeBehind="frmCliente.aspx.cs" Inherits="SolSeguridad.Intranet.frmCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Bienvenido a su Consultoria</h1>
    
    <asp:LoginName ID="LoginName1" runat="server" />
    <br />
    <br />
    <asp:LoginStatus ID="LoginStatus1" runat="server" OnLoggingOut="LoginStatus1_LoggingOut" />
    
</asp:Content>
