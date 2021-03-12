using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using study_winform_graphics.View;

namespace study_winform_graphics
{
	public partial class Form1 : Form
	{
		private DateComponent dateComponent;
		private FurnacesComponent furnacesComponent;
		private ScheduleComponent scheduleComponent;

		public Form1()
		{
			InitializeComponent();

			this.dateComponent = new DateComponent();
			this.furnacesComponent = new FurnacesComponent();
			this.scheduleComponent = new ScheduleComponent();

			MainTableLayout.Controls.Add(this.furnacesComponent, 0, 0);
			MainTableLayout.SetRowSpan(this.furnacesComponent, 3);

			MainTableLayout.Controls.Add(this.dateComponent, 1, 0);
			MainTableLayout.SetRowSpan(this.dateComponent, 2);

			MainTableLayout.Controls.Add(this.scheduleComponent, 1, 2);
		}
	}
}
