<%@ Page Title="" Language="C#" MasterPageFile="~/Master/BaseView.Master" AutoEventWireup="true" CodeBehind="SearchClienteView.aspx.cs" Inherits="WebPresentation.ClienteViews.SearchClienteView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="DivContent">
        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="Label1" runat="server" Text="Pesquisar por nome:"></asp:Label>
            <asp:TextBox CssClass="CamposTextBox" ID="NomeTextBox" runat="server" Width="250px"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="Label2" runat="server" Text="Pesquisar por ID:"></asp:Label>
            <asp:TextBox CssClass="CamposTextBox"  ID="IdTextBox" runat="server" Width="250px"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <span id="GroupButtons" >
                <asp:Button CssClass="MenuButton" ID="HomeButton" runat="server" Text="HOME" PostBackUrl="~/Index.aspx" />
                <asp:Button CssClass="MenuButton" ID="LimparButton" runat="server" Text="LIMPAR" OnClick="LimparButton_Click"/>
                <asp:Button CssClass="MenuButton" ID="BuscarButton" runat="server" Text="BUSCAR" OnClick="BuscarButton_Click" />
            </span>
        </div>
        <div class="CamposDiv">
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="MensagemLabel" runat="server" BorderStyle="None" Font-Size="Medium" ForeColor="Red" Height="30px"></asp:Label>
        </div>
    </div>    
</asp:Content>
