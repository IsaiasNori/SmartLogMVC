using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Web.UI;

namespace WebPresentation.ExtensionMethods
{
    public static class ValidationFields
    {
        public static string RequiredField(this TextBox txt)
        {
            if (txt.Text == "")
            {
                throw new Exception("Campos com * são Obrigatórios!");
            }
            return txt.Text.Trim();
        }

        public static string RequiredRegularAddressMail(this TextBox txt)
        {
            if (!Regex.IsMatch(txt.RequiredField(), @"^[a-zA-Z0-9\._\-]+\@+[a-zA-Z0-9\._\-]+\.[a-zA-Z]+$"))
            {
                txt.Focus();
                throw new Exception("Informe um e-mail Válido!");
            }
            return txt.Text;
        }
    }
    
}