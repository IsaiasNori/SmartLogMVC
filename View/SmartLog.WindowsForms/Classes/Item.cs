using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLog.WindowsForms.DeskTopPresentation.Classes
{
	public class Item
	{
		public string Name;
		public object Value;
		public Item(string name, object value)
		{
			Name = name; Value = value;
		}
		public override string ToString()
		{
			// Generates the text shown in the combo box
			return Name;
		}
	}
}
