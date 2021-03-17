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
using mvc_pattern.Model;
using mvc_pattern.Model.Entity;
using mvc_pattern.Controller;

namespace mvc_pattern.View
{
	partial class SchedulingView : UserControl
	{
		public SchedulingController controller;

		public SchedulingView()
		{
			InitializeComponent();
		}

		public void setListView()
		{
			// 데이터로 화면 구성 ( 헤더 )
			string[] furnaceHeader = new string[] { "설비명", "원재료", "용량(kg)", "잔여용탕(kg)", "이전작업 종료시간", "용해 소요시간", "금형교체시간", "보온전력(kW)", "가열전력(kW)" };
			FurnacesView.Columns.Clear();
			foreach (string furnace in furnaceHeader)
				FurnacesView.Columns.Add(new ColumnHeader() { Text = furnace, Width = 100 });
			foreach (Furnace furnace in this.controller.model.furnaces)
				FurnacesView.Items.Add(new ListViewItem(furnace.toStringArray()));

			ProductsView.Columns.Clear();
			string[] productsHeader = new string[] { "제품명", "원재료", "소모용량(kg)", "생산시간", "불량률(%)" };
			foreach (string product in productsHeader)
				ProductsView.Columns.Add(new ColumnHeader() { Text = product, Width = 100 });
			foreach (Product product in this.controller.model.products)
				ProductsView.Items.Add(new ListViewItem(product.toStringArray()));

			OrdersView.Columns.Clear();
			string[] orderHeader = new string[] { "제품명", "주문수량", "주문일자", "납기일자" };
			foreach (string order in orderHeader)
				OrdersView.Columns.Add(new ColumnHeader() { Text = order, Width = 100 });
			foreach (Order order in this.controller.model.orders)
				OrdersView.Items.Add(new ListViewItem(order.toStringArray()));
		}

		public void makeSchedulingSuccess()
		{
			Console.WriteLine("데이터 세팅 완료");

			foreach (Furnace furnace in this.controller.model.furnaces)
			{
				Console.Write(furnace.name + " ");
				foreach(Product product in furnace.furnaceScheduling.ableLot)
				{
					Console.WriteLine(product.name);
				}

				foreach(Order order in furnace.furnaceScheduling.ableOrder)
				{
					Console.WriteLine(order.name);
				}
			}
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

		private void MakeSchedulingButton_Click(object sender, EventArgs e)
		{
			this.controller.makeScheduling();
		}
	}
}
