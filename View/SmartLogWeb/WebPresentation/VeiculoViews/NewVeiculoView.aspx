<%@ Page Title="" Language="C#" MasterPageFile="~/Master/BaseView.Master" AutoEventWireup="true" CodeBehind="NewVeiculoView.aspx.cs" Inherits="WebPresentation.VeiculoViews.NewVeiculoView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="DivContent">
        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="Label13" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox CssClass="CamposTextBox" ID="IdTextBox" runat="server" Width="50px" Enabled="False"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="Label1" runat="server" Text="Marca:"></asp:Label>
            <asp:TextBox CssClass="CamposTextBox" ID="MarcaTextBox" runat="server" Width="200px"></asp:TextBox>
            <asp:Label ID="Label10" runat="server" Text="*"></asp:Label>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label2" runat="server" Text="Modelo:" CssClass="CamposLabel"></asp:Label>
            <asp:TextBox ID="ModeloTextBox" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
            <asp:Label ID="Label11" runat="server" Text="*"></asp:Label>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label3" runat="server" Text="Placa:" CssClass="CamposLabel"></asp:Label>
            <asp:TextBox ID="PlacaTextBox" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
            <asp:Label ID="Label12" runat="server" Text="*"></asp:Label>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label4" runat="server" Text="Ano Fabricação:" CssClass="CamposLabel"></asp:Label>
            <asp:TextBox ID="AnoTextBox" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label5" runat="server" Text="Status:" CssClass="CamposLabel"></asp:Label>
            <asp:TextBox ID="StatusTextBox" runat="server" Width="100px" CssClass="CamposTextBox"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <span id="GroupButtons" >
                <asp:Button class="MenuButton" ID="HomeButton" runat="server" Text="HOME" PostBackUrl="~/Index.aspx"/>
                <asp:Button class="MenuButton" ID="LimparButton" runat="server" Text="LIMPAR" />
                <asp:Button class="MenuButton" ID="SalvarButton" runat="server" Text="SALVAR" />
            </span>
        </div>
        <div class="CamposDiv">
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="MensagemLabel" runat="server" BorderStyle="None" Font-Size="Medium" ForeColor="Red" Height="30px"></asp:Label>
        </div>
</asp:Content>
