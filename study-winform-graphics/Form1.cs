using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using study_winform_graphics.view;

namespace study_winform_graphics
{
	public partial class Form1 : Form
	{
		private ScheduleComponent schduleComponent;
		private SchedulingComponent schedulingComponent;
		private TableLayoutComponent tableLayoutComponent;

		public Form1()
		{
			InitializeComponent();

			this.schduleComponent = new ScheduleComponent();
			this.schedulingComponent = new SchedulingComponent();
			this.tableLayoutComponent = new TableLayoutComponent();

			userView.Controls.Add(this.schedulingComponent);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			String title = "안녕하세요.\r\n태헌의 스터디룸 입니다.";
			titleBox.Text = title;
			titleBox.ReadOnly = true;
		}

		private void componentChange(object sender, EventArgs e)
		{
			Button clickBtn = (Button)sender;

			switch(clickBtn.Name)
			{
				case "btn_changeSchedule":
					userView.Controls.Clear();
					userView.Controls.Add(this.schduleComponent);
					break;
				case "btn_changeScheduling":
					userView.Controls.Clear();
					userView.Controls.Add(this.schedulingComponent);
					break;
				case "btn_changeTableLayout":
					userView.Controls.Clear();
					userView.Controls.Add(this.tableLayoutComponent);
					break;
			}
		}
	}
}
