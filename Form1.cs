using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using study_winform_graphics.View;
using study_winform_graphics.Model;
using System.Threading;

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

		private void FileLoadAction(Object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog()
			{
				Filter = "(*.csv)|*.csv",
			};

			if (ofd.ShowDialog() != DialogResult.OK)
				return;

			Console.WriteLine("파일 path");
			Console.WriteLine(ofd.FileName);

			string[] lines = File.ReadAllLines(ofd.FileName);
			List<Schedule> scheduleList = new List<Schedule>();

			for(int l = 1; l < lines.Length; l++)
			{
				string[] cols = lines[l].Split(','); 

				Console.WriteLine(lines[l]);
				
				// 첫 시작
				if(l == 1 || scheduleList[scheduleList.Count - 1].furnace != cols[0] || scheduleList[scheduleList.Count - 1].lot != cols[1])
				{
					scheduleList.Add(new Schedule(cols));
				} else
				{
					scheduleList[scheduleList.Count - 1].endTime = DateTime.Parse(cols[3]);
				}
			}

			this.scheduleComponent.drawSchedule(scheduleList.ToArray());

			/*
				for(int s = 0; s < scheduleList.Count; s++)
				{
					scheduleList[s].toString();
					Thread.Sleep(1000);
				}
			*/
		}
	}
}
