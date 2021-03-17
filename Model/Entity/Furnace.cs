using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;

namespace mvc_pattern.Model.Entity
{
	class Furnace
	{
		public string name;
		public string material;
		public int volume; // or casterCapacity
		public int restVolume; // or casterCurrentVolume
		public DateTime previousWorkTime; // or casterScheduleStartTime
		public DateTime minTime; // ?
		public DateTime meltingTime; // or casterMinTime
		public DateTime holdingTime; // or casterMoldChangeTime
		public int holdingKw;
		public int workingKw;
		public FurnaceScheduling furnaceScheduling;

		public Furnace(string[] strArr)
		{
			this.name = strArr[0];
			this.material = strArr[1];
			this.volume = int.Parse(strArr[2]);
			this.restVolume = int.Parse(strArr[3]);
			this.previousWorkTime = DateTime.Parse(strArr[4]);
			this.meltingTime = DateTime.Parse(strArr[5]);
			this.holdingTime = DateTime.Parse(strArr[6]);
			this.holdingKw = int.Parse(strArr[7]);
			this.workingKw = int.Parse(strArr[8]);
		}

		public Furnace(Furnace f)
		{
			this.name = f.name;
			this.material = f.material;
			this.volume = f.volume;
			this.restVolume = f.restVolume;
			this.previousWorkTime = f.previousWorkTime;
			this.meltingTime = f.meltingTime;
			this.holdingTime = f.holdingTime;
			this.holdingKw = f.holdingKw;
			this.workingKw = f.workingKw;
			this.furnaceScheduling = new FurnaceScheduling(f.furnaceScheduling);
		}

		public string[] toStringArray()
		{
			return new string[] {
				this.name,
				this.material,
				this.volume.ToString(),
				this.restVolume.ToString(),
				this.previousWorkTime.ToString(),
				this.meltingTime.ToString(),
				this.holdingTime.ToString(),
				this.holdingKw.ToString(),
				this.workingKw.ToString(),
			};
		}

		public void setSchedulingData(SchedulingModel model)
		{
			List<Product> ableLot;
			List<Order> ableOrder;

			// 재료가 같은 경우 투입
			ableLot = model.products.FindAll(product => product.material.Equals(this.material));
			// 주문명 == 제품명
			ableOrder = model.orders.FindAll(order => model.products.Any(product => product.name.Equals(order.name)));

			this.furnaceScheduling = new FurnaceScheduling(ableLot, ableOrder);
		}
	}

	class FurnaceScheduling
	{
		public List<Product> ableLot;
		public List<Order> ableOrder;
		public List<int> orderBak;
		public int productionVolume;

		public FurnaceScheduling(List<Product> ableLot, List<Order> ableOrder)
		{
			this.ableLot = ableLot;
			this.ableOrder = ableOrder;
			this.orderBak = new List<int>();
			this.productionVolume = 0;
		}

		public FurnaceScheduling(FurnaceScheduling f)
		{
			this.ableLot = f.ableLot;
			this.ableOrder = f.ableOrder;
			this.orderBak = new List<int>();
			this.productionVolume = 0;
		}

		public void setOrderBak(int orderIdx, bool isClear = false)
		{
			if (isClear) { 
				orderBak.Clear();
				return;
			}

			orderBak.Add(orderIdx);
		}
	}
}
