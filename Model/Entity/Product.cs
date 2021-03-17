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
			this.productScheduling = new ProductScheduling(order.quantity + (order.quantity * this.defectRate));
		}
	}

	class ProductScheduling
	{
		public int requiredQuantity;

		public ProductScheduling(int requiredQuantity)
		{
			this.requiredQuantity = requiredQuantity;
		}
	}
}
