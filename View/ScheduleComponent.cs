using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using study_winform_graphics.Model;

namespace study_winform_graphics.View
{
	public partial class ScheduleComponent : UserControl
	{
		private Schedule[] scheduleList { get; set; }
		public ScheduleComponent()
		{
			InitializeComponent();
			Dock = DockStyle.Fill;
			BackColor = Color.Blue;
		}
	}
}
