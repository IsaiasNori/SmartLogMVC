using System;
using WebPresentation.ExtensionMethods;
using WebPresentation.ClienteViews;
using WebPresentation.Master;

namespace WebPresentation.SideMenu
{
    public partial class SideMenuControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClientPanel.Visible = false;
                ViagemPanel.Visible = false;
                VeiculoPanel.Visible = false;
                FuncionarioPanel.Visible = false;
            }
        }

        protected void MenuClientButton_Click(object sender, EventArgs e)
        {
            ClientPanel.PanelAction();
        }

        protected void MenuViagemButton_Click(object sender, EventArgs e)
        {
            ViagemPanel.PanelAction();
        }

        protected void MenuVeiculoButton_Click(object sender, EventArgs e)
        {
            VeiculoPanel.PanelAction();
        }

        protected void MenuFuncionarioButton_Click(object sender, EventArgs e)
        {
            FuncionarioPanel.PanelAction();
        }
    }
}