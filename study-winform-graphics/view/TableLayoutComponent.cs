using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using study_winform_graphics.view.tableView;

namespace study_winform_graphics.view
{
	public partial class TableLayoutComponent : UserControl
	{
		public TableLayoutComponent()
		{
			InitializeComponent();
			tableLayoutPanal.Dock = DockStyle.Fill;

			Color cOne = Color.Black;
			Color cTwo = Color.Red;
			Color cThree = Color.Green;
			Color cFour = Color.Blue;

			for(int i = 0; i < 2; i++)
			{
				for(int j=0; j< 2; j++)
				{
					tableLayoutPanal.Controls.Add(
						new tableOne()
						{
							BackColor = cOne
						},
						i,
						j
						);
				}
			}
		}
	}
}
