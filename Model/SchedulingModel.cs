using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvc_pattern.Model.Entity;

namespace mvc_pattern.Model
{
	public class SchedulingModel
	{
		List<Furnace> furnaces;
		List<Product> products;
		List<Order> orders;

		public SchedulingModel()
		{
			this.furnaces = new List<Furnace>();
			this.products = new List<Product>();
			this.orders = new List<Order>();
		}
	}
}
