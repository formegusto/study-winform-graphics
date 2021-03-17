using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_pattern.Model.Entity
{
	class Product
	{
		public string name;
		public string material;
		public int workingVolume;
		public DateTime workingTime;
		public int defectRate;
		public ProductScheduling productScheduling;

		public Product(string[] strArr)
		{
			this.name = strArr[0];
			this.material = strArr[1];
			this.workingVolume = int.Parse(strArr[2]);
			this.workingTime = DateTime.Parse(strArr[3]);
			this.defectRate = int.Parse(strArr[4]);
		}
		public Product(Product p)
		{
			this.name = p.name;
			this.material = p.material;
			this.workingVolume = p.workingVolume;
			this.workingTime = p.workingTime;
			this.defectRate = p.defectRate;
			this.productScheduling = new ProductScheduling(p.productScheduling);
		}
		public string[] toStringArray()
		{
			return new string[] {
				this.name,
				this.material,
				this.workingVolume.ToString(),
				this.workingTime.ToString(),
				this.defectRate.ToString(),
			};
		}

		public void setSchedulingData(Order order)
		{
			this.productScheduling = new ProductScheduling(order.quantity + (int)(order.quantity * (this.defectRate / 100.0)));
		}
	}

	class ProductScheduling
	{
		public int quantity;
		public int requiredQuantity;
		// 제품 생산이 끝난 시간
		public DateTime clearTime;
		public bool isClear;

		public ProductScheduling(int requiredQuantity)
		{
			this.quantity = requiredQuantity;
			this.requiredQuantity = requiredQuantity;
			this.isClear = false;
		}

		public ProductScheduling(ProductScheduling ps)
		{
			this.quantity = ps.requiredQuantity;
			this.requiredQuantity = ps.requiredQuantity;
			this.isClear = ps.isClear;
		}

		public void setQuantity()
		{
			--this.requiredQuantity;

			if (requiredQuantity == 0)
			{
				// Console.WriteLine("제품 생산 끝");
				isClear = true;
			}
		}

		public void setQuantity(int requiredQuantity, DateTime clearTime)
		{
			this.requiredQuantity = requiredQuantity;
			this.clearTime = clearTime;

			if(requiredQuantity == 0)
			{
				// Console.WriteLine("제품 생산 끝");
				isClear = true;
			}
		}
	}
}
