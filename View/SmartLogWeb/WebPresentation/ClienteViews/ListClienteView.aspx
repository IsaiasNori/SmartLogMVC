<%@ Page Title="" Language="C#" MasterPageFile="~/Master/BaseView.Master" AutoEventWireup="true" CodeBehind="ListClienteView.aspx.cs" Inherits="WebPresentation.ClienteViews.ListClienteView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="DivListCliente" class="DivContent">
        <asp:DataList ID="ListCliente" runat="server"></asp:DataList>
    </div>
</asp:Content>
