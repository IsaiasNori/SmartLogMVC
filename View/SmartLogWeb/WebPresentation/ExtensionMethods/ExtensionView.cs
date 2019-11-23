using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPresentation.ExtensionMethods
{
    public static class ExtensionView
    {
        public static void ClearText(this WebControl ctr)
        {
            if (ctr is TextBox)
            {
                (ctr as TextBox).Text = "";
            }
            else if(ctr is Label)
            {
                (ctr as Label).Text = "";
            }
        }

        public static void PanelAction(this Panel pnl)
        {
            if (pnl.Visible)
            {
                pnl.Visible = false;
            }
            else
            {
                pnl.Visible = true;
            }
        }


    }
}