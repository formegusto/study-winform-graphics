using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using mvc_pattern.Model.Entity;

namespace mvc_pattern.Service.Scheduling
{
	public class SchedulingServiceImpl : SchedulingService
	{
		public void setDataFromExcel(string path)
		{
			Excel.Application excelApp = null;
			Excel.Workbook workbook = null;
			Excel.Worksheet worksheet = null;
			Excel.Range range = null;

			try
			{
				excelApp = new Excel.Application();
				workbook = excelApp.Workbooks.Open(path);

				workbook.Close(true);
				excelApp.Quit();
			}
			finally
			{
				void ReleaseObject(object obj)
				{
					try
					{
						if (obj != null)
						{
							Marshal.ReleaseComObject(obj);
							obj = null;
						}
					}
					catch (Exception ex)
					{
						obj = null;
						throw ex;
					}
					finally
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
