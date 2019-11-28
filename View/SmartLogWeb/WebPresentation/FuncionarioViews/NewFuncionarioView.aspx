<%@ Page Title="" Language="C#" MasterPageFile="~/Master/BaseView.Master" AutoEventWireup="true" CodeBehind="NewFuncionarioView.aspx.cs" Inherits="WebPresentation.FuncionarioViews.NewFuncionarioView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="DivContent">
        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="Label13" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox CssClass="CamposTextBox" ID="IdTextBox" runat="server" Width="50px" Enabled="False"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="Label1" runat="server" Text="Nome:"></asp:Label>
            <asp:TextBox CssClass="CamposTextBox" ID="NomeTextBox" runat="server" Width="400px"></asp:TextBox>
            <asp:Label ID="Label10" runat="server" Text="*"></asp:Label>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label2" runat="server" Text="Email:" CssClass="CamposLabel"></asp:Label>
            <asp:TextBox ID="EmailTextBox" runat="server" Width="400px" CssClass="CamposTextBox"></asp:TextBox>
            <asp:Label ID="Label11" runat="server" Text="*"></asp:Label>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label3" runat="server" Text="Telefone:" CssClass="CamposLabel"></asp:Label>
            <asp:TextBox ID="TelefoneTextBox" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
            <asp:Label ID="Label12" runat="server" Text="*"></asp:Label>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label4" runat="server" Text="Logradouro:" CssClass="CamposLabel"></asp:Label>
            <asp:TextBox ID="LogradouroTextBox" runat="server" Width="400px" CssClass="CamposTextBox"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label5" runat="server" Text="Número:" CssClass="CamposLabel"></asp:Label>
            <asp:TextBox ID="NumeroTextBox" runat="server" Width="100px" CssClass="CamposTextBox"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label6" runat="server" Text="CEP:" CssClass="CamposLabel"></asp:Label>
            <asp:TextBox ID="CepTextBox" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label7" runat="server" Text="Bairro:" CssClass="CamposLabel"></asp:Label>
            <asp:TextBox ID="BairroTextBox" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label8" runat="server" Text="Cidade:" CssClass="CamposLabel"></asp:Label>
            <asp:TextBox ID="CidadeTextBox" runat="server" Width="200px" CssClass="CamposTextBox"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <asp:Label ID="Label9" runat="server" Text="UF:" CssClass="CamposLabel"></asp:Label>
            <asp:DropDownList ID="UfDropDownList" runat="server" Width="50px" CssClass="CamposTextBox" AutoPostBack="True" ForeColor="Black">
            </asp:DropDownList>
        </div>
        <div class="CamposDiv">
            <span id="GroupButtons" >
                <asp:Button class="MenuButton" ID="HomeButton" runat="server" Text="HOME" PostBackUrl="~/Index.aspx"/>
                <asp:Button class="MenuButton" ID="LimparButton" runat="server" Text="LIMPAR"/>
                <asp:Button class="MenuButton" ID="SalvarButton" runat="server" Text="SALVAR"/>
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
