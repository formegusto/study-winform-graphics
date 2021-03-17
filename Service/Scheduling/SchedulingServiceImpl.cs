using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using mvc_pattern.Model;
using mvc_pattern.Model.Entity;

namespace mvc_pattern.Service.Scheduling
{
	class SchedulingServiceImpl : SchedulingService
	{
		public SchedulingModel getModelFromExcel(string path)
		{
			SchedulingModel rtnModel = new SchedulingModel();

			Excel.Application excelApp = null;
			Excel.Workbook workbook = null;
			Excel.Worksheet worksheet = null;
			Excel.Range range = null;

			try
			{
				excelApp = new Excel.Application();
				workbook = excelApp.Workbooks.Open(path);
					
				for(int s = 1; s <= workbook.Worksheets.Count; s++)
				{
					worksheet = workbook.Worksheets.get_Item(s) as Excel.Worksheet;
					range = worksheet.UsedRange;
					switch(s)
					{
						// 설비 정보
						case 1:
							for(int r = 3; r <= range.Rows.Count; r++)
							{
								if (range.Cells[r, 1] == null)
									continue;
								List<string> furnaceStrList = new List<string>();
								for(int c = 1; c <= range.Columns.Count; c++)
									furnaceStrList.Add(range.Cells[r, c].Value2);
								rtnModel.furnaces.Add(new Furnace(furnaceStrList.ToArray()));
							}
							break;

						// 제품 정보
						case 2:
							for (int r = 3; r <= range.Rows.Count; r++)
							{
								if (range.Cells[r, 1] == null)
									continue;
								List<string> productStrList = new List<string>();
								for (int c = 1; c <= range.Columns.Count; c++)
									productStrList.Add(range.Cells[r, c].Value2);
								rtnModel.products.Add(new Product(productStrList.ToArray()));
							}
							break;

						// 주문 정보
						case 3:
							for (int r = 3; r <= range.Rows.Count; r++)
							{
								if (range.Cells[r, 1] == null)
									continue;
								List<string> orderStrList = new List<string>();
								for (int c = 1; c <= range.Columns.Count; c++)
									orderStrList.Add(range.Cells[r, c].Value2);
								rtnModel.orders.Add(new Order(orderStrList.ToArray()));
							}
							break;
					}
				}

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

			return rtnModel;
		}

		public SchedulingModel setSchedulingData(SchedulingModel model)
		{
			SchedulingModel rtnModel = model;

			foreach(Furnace furnace in rtnModel.furnaces)
				furnace.setSchedulingData(model);

			foreach (Product product in rtnModel.products)
				product.setSchedulingData(rtnModel.orders.Find(order => order.name == product.name));

			return rtnModel;
		}
	}
}
