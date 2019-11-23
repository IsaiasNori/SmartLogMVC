<%@ Page Title="" Language="C#" MasterPageFile="~/Master/BaseView.Master" AutoEventWireup="true" CodeBehind="ListViagemView.aspx.cs" Inherits="WebPresentation.ViagemViews.ListViagemView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="DivViagemCliente" class="DivContent">
        <asp:DataList ID="ListViagem" runat="server"></asp:DataList>
    </div>
</asp:Content>
