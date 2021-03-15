using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mvc_pattern.Controller;

namespace mvc_pattern
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			AutoSize = true;

			UserView.Controls.Add(new SchedulingController().view);
		}
	}
}
