using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SmartLogBusiness.Model.Entidade.pessoa;
using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.Controller;
using System.Data;

namespace WebPresentation.ClienteViews
{
    public partial class ListClienteView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IControllerBase<Cliente> controllerBase = new ClienteController();

            

        }
    }
}