using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using study_winform_graphics.Model;

namespace study_winform_graphics.View
{
	partial class ScheduleComponent : UserControl
	{
		private Schedule[] scheduleList { get; set; }

		public ScheduleComponent()
		{
			InitializeComponent();

			Dock = DockStyle.Fill;
			BackColor = Color.White;

			ScheduleCanvas.Size = new Size(1200, 1200);
			ScheduleCanvas.AutoScroll = true;
			ScheduleCanvas.AutoSize = true;
		}

		public void drawSchedule(Schedule[] scheduleList)
		{
			Graphics g = ScheduleCanvas.CreateGraphics();
			g.Clear(this.BackColor);

			Brush meltBrush = Brushes.Red;
			Brush lotBrush = Brushes.Green;

			// 초기화
			int x = 0;
			int y = -1;

			for(int s = 0; s < 5; s++)
			{
				scheduleList[s].toString();
				Console.WriteLine(x);
				Thread.Sleep(1000);
				Brush brush;

				if (scheduleList[s].lot.Equals("용해작업"))
				{
					y++;
					brush = Brushes.Red;
				} else if(scheduleList[s].lot.Equals("금형교체"))
				{
					brush = Brushes.Transparent;
				} else
				{
					brush = Brushes.Green;
				}

				Rectangle scheduleBar = new Rectangle(x, (y == -1 ? 0 : y) * 12, (int)(((scheduleList[s].endTime - scheduleList[s].startTime).TotalMinutes / 60) * 100), 12);

				g.FillRectangle(brush, scheduleBar);

				// 포지션 정리
				x += (int)(((scheduleList[s].endTime - scheduleList[s].startTime).TotalMinutes / 60) * 100);
			}
			g.Dispose();
		}

		protected override void OnScroll(ScrollEventArgs se)
		{
			base.OnScroll(se);
			this.Invalidate(false);
		}
	}
}
