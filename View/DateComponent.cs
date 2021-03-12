using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_winform_graphics.View
{
	public partial class DateComponent : UserControl
	{
		public DateComponent()
		{
			InitializeComponent();
			Dock = DockStyle.Fill;
			BackColor = Color.Green;
		}
	}
}
