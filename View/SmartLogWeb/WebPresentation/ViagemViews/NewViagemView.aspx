<%@ Page Title="" Language="C#" MasterPageFile="~/Master/BaseView.Master" AutoEventWireup="true" CodeBehind="NewViagemView.aspx.cs" Inherits="WebPresentation.ViagemViews.NewViagemView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="DivContent">

        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="Label13" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox CssClass="CamposTextBox" ID="IdTextBox" runat="server" Width="50px" Enabled="False"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="label" runat="server" Text="Cliente"></asp:Label>
            <asp:DropDownList class="CamposTextBox" ID="ClienteDropDownList" runat="server" Width="300px"></asp:DropDownList>
            <asp:Button class="StandardButton" ID="NewClienteButton" runat="server" Text="Cadastrar Novo" />
        </div>
        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="label1" runat="server" Text="Data:"></asp:Label>
            <asp:TextBox CssClass="CamposTextBox" ID="DataTextBox" runat="server" Width="130px"></asp:TextBox>
        </div>
        <div class="GroupBox">
            <h1>Origem:</h1>
            <div class="CamposDiv">
                <asp:Label ID="Label6" runat="server" Text="Logradouro:" CssClass="CamposLabel"></asp:Label>
                <asp:TextBox ID="LogradouroTextBox" runat="server" Width="400px" CssClass="CamposTextBox"></asp:TextBox>
            </div>
            <div class="CamposDiv">
                <asp:Label ID="Label7" runat="server" Text="Número:" CssClass="CamposLabel"></asp:Label>
                <asp:TextBox ID="NumeroTextBox" runat="server" Width="100px" CssClass="CamposTextBox"></asp:TextBox>
            </div>
            <div class="CamposDiv">
                <asp:Label ID="Label8" runat="server" Text="CEP:" CssClass="CamposLabel"></asp:Label>
                <asp:TextBox ID="CepTextBox" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
            </div>
            <div class="CamposDiv">
                <asp:Label ID="Label9" runat="server" Text="Bairro:" CssClass="CamposLabel"></asp:Label>
                <asp:TextBox ID="BairroTextBox" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
            </div>
            <div class="CamposDiv">
                <asp:Label ID="Label14" runat="server" Text="Cidade:" CssClass="CamposLabel"></asp:Label>
                <asp:TextBox ID="CidadeTextBox" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
            </div>
            <div class="CamposDiv">
                <asp:Label ID="Label15" runat="server" Text="UF:" CssClass="CamposLabel"></asp:Label>
                <asp:DropDownList ID="UfDropDownList" runat="server" Width="50px" CssClass="CamposTextBox"></asp:DropDownList>
            </div>
        </div>
        <div class="GroupBox">
            <h1>Destino:</h1>
            <div class="CamposDiv">
                <asp:Label ID="Label22" runat="server" Text="Logradouro:" CssClass="CamposLabel"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" Width="400px" CssClass="CamposTextBox"></asp:TextBox>
            </div>
            <div class="CamposDiv">
                <asp:Label ID="Label23" runat="server" Text="Número:" CssClass="CamposLabel"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" Width="100px" CssClass="CamposTextBox"></asp:TextBox>
            </div>
            <div class="CamposDiv">
                <asp:Label ID="Label24" runat="server" Text="CEP:" CssClass="CamposLabel"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
            </div>
            <div class="CamposDiv">
                <asp:Label ID="Label25" runat="server" Text="Bairro:" CssClass="CamposLabel"></asp:Label>
                <asp:TextBox ID="TextBox9" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
            </div>
            <div class="CamposDiv">
                <asp:Label ID="Label26" runat="server" Text="Cidade:" CssClass="CamposLabel"></asp:Label>
                <asp:TextBox ID="TextBox10" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
            </div>
            <div class="CamposDiv">
                <asp:Label ID="Label27" runat="server" Text="UF:" CssClass="CamposLabel"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="50px" CssClass="CamposTextBox"></asp:DropDownList>
            </div>
        </div>
    </div>
</asp:Content>
