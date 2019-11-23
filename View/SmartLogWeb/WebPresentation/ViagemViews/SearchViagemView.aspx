<%@ Page Title="" Language="C#" MasterPageFile="~/Master/BaseView.Master" AutoEventWireup="true" CodeBehind="SearchViagemView.aspx.cs" Inherits="WebPresentation.ViagemViews.SearchViagemView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="DivContent">
        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="Label1" runat="server" Text="Data:"></asp:Label>
            <asp:TextBox CssClass="CamposTextBox" ID="DataTextBox" runat="server" Width="130px"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="Label2" runat="server" Text="Cliente:"></asp:Label>
            <asp:TextBox CssClass="CamposTextBox"  ID="ClienteTextBox" runat="server" Width="400px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>ou</strong></div>
        <div class="CamposDiv">
            <asp:Label CssClass="CamposLabel" ID="Label3" runat="server" Text="Cód Viagem:"></asp:Label>
            <asp:TextBox CssClass="CamposTextBox"  ID="CodViagemTextBox" runat="server" Width="100px"></asp:TextBox>
        </div>
        <div class="CamposDiv">
            <span id="GroupButtons" >
                <asp:Button CssClass="MenuButton" ID="HomeButton" runat="server" Text="HOME" PostBackUrl="~/Index.aspx" />
                <asp:Button CssClass="MenuButton" ID="LimparButton" runat="server" Text="LIMPAR"/>
                <asp:Button CssClass="MenuButton" ID="BuscarButton" runat="server" Text="BUSCAR"/>
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
