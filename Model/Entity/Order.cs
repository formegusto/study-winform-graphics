using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_pattern.Model.Entity
{
	class Order
	{
		public string name;
		public int quantity;
		public DateTime orderTime;
		public DateTime finishTime;

		public void setOrderFromStringArray(string[] strArr)
		{
			this.name = strArr[0];
			this.quantity = int.Parse(strArr[1]);
			this.orderTime = DateTime.Parse(strArr[2]);
			this.finishTime = DateTime.Parse(strArr[3]);
		}
	}
}
