using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPresentation.Master
{
    public partial class BaseView : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void SideMenuButton_Click(object sender, EventArgs e)
        {
            SideMenuControl.Visible = (SideMenuControl.Visible) ?  false : true;
        }
    }
}