using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLog.WindowsForms.UserControl
{
    public class SuperComboBox : ComboBox
    {
        public bool CampoObrigatorio { get; set; }
        public string MensagemCampoObrigatorio { get; set; }
    }
}
