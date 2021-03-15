using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace mvc_pattern.View
{
	public partial class SchedulingView : UserControl
	{
		public SchedulingView()
		{
			InitializeComponent();
		}

		private void ExcelLoadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog()
			{
				Filter = "(*.csv)|*.csv",
			};

			if (ofd.ShowDialog() != DialogResult.OK)
				return;

			Excel.Application excelApp = null;
			Excel.Workbook workbook = null;
			Excel.Worksheet worksheet = null;
			Excel.Range range = null;

			try
			{
				workbook.Close(true);
				excelApp.Quit();
			} finally
			{
				void ReleaseObject(object obj)
				{
					try
					{
						if(obj != null)
						{
							Marshal.ReleaseComObject(obj);
							obj = null;
						}
					} catch(Exception ex)
					{
						obj = null;
						throw ex;
					} finally
					{
						GC.Collect();
					}
				}
				ReleaseObject(worksheet);
				ReleaseObject(workbook);
				ReleaseObject(excelApp);
			}
		}
	}
}
