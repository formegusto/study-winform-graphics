using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using mvc_pattern.Controller;

namespace mvc_pattern.View
{
	public partial class SchedulingView : UserControl
	{
		public SchedulingController controller;

		public SchedulingView()
		{
			InitializeComponent();
		}

		private void ExcelLoadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog()
			{
				Filter = "(*.xlsx)|*.xlsx",
			};

			if (ofd.ShowDialog() != DialogResult.OK)
				return;

			this.controller.setDataFromExcel(ofd.FileName);
		}
	}
}
