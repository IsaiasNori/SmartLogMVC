<%@ Control Language="C#" AutoEventWireup="true"  CodeBehind="SideMenuControl.ascx.cs" Inherits="WebPresentation.SideMenu.SideMenuControl" %>

<asp:Panel ID="SideMenuPanel" runat="server" Width="180px" Height="100%" ScrollBars="Auto" CssClass="SideMenuColor">
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    

    <br />
    <br />
    <br />
    <br />

    <asp:Button ID="MenuClientButton" runat="server" Text="Cliente" Height="35px" Width="180px" CssClass="LateralButtonParent" OnClick="MenuClientButton_Click" BorderStyle="None" />
    <asp:Panel ID="ClientPanel" runat="server" Width="180px">
        <asp:Button ID="NewClientButton" runat="server" Text="Novo" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None" PostBackUrl="~/ClienteViews/NewClienteView.aspx" />
        <asp:Button ID="SearchClientButton" runat="server" Text="Busca" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None"  PostBackUrl="~/ClienteViews/SearchClienteView.aspx" />
        <asp:Button ID="ListClientButton" runat="server" Text="Lista" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None" PostBackUrl="~/ClienteViews/ListClienteView.aspx" />
    </asp:Panel>

    <asp:Button ID="MenuViagemButton" runat="server" Text="Viagem" Height="35px" Width="180px" CssClass="LateralButtonParent" OnClick="MenuViagemButton_Click" BorderStyle="None" />
    <asp:Panel ID="ViagemPanel" runat="server" Width="180px">
        <asp:Button ID="NewViagemButton" runat="server" Text="Novo" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None" PostBackUrl="~/ViagemViews/NewViagemView.aspx" />
        <asp:Button ID="SearchViagemButton" runat="server" Text="Busca" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None" PostBackUrl="~/ViagemViews/SearchViagemView.aspx" />
        <asp:Button ID="ListViagemButton" runat="server" Text="Lista" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None" PostBackUrl="~/ViagemViews/ListViagemView.aspx" />
    </asp:Panel>

    <asp:Button ID="MenuVeiculoButton" runat="server" Text="Veículo" Height="35px" Width="180px" CssClass="LateralButtonParent" OnClick="MenuVeiculoButton_Click" BorderStyle="None" />
    <asp:Panel ID="VeiculoPanel" runat="server" Width="180px">
        <asp:Button ID="NewVeiculoButton" runat="server" Text="Novo" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None" />
        <asp:Button ID="SearchVeiculoButton" runat="server" Text="Busca" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None" />
        <asp:Button ID="ListVeiculoButton" runat="server" Text="Lista" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None" />
    </asp:Panel>

    <asp:Button ID="MenuFuncionarioButton" runat="server" Text="Funcionário" Height="35px" Width="180px" CssClass="LateralButtonParent" OnClick="MenuFuncionarioButton_Click" BorderStyle="None" />
    <asp:Panel ID="FuncionarioPanel" runat="server" Width="180px">
        <asp:Button ID="NewFuncionarioButton" runat="server" Text="Novo" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None" />
        <asp:Button ID="SeacrhFuncionarioButton" runat="server" Text="Busca" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None" />
        <asp:Button ID="ListFuncionarioButton" runat="server" Text="Lista" Height="35px" Width="180px" CssClass="LateralButtonChild" BorderStyle="None" />
    </asp:Panel>
</asp:Panel>
