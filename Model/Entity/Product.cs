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

		public void setProductFromStringArray(string[] strArr)
		{
			this.name = strArr[0];
			this.material = strArr[1];
			this.workingVolume = int.Parse(strArr[2]);
			this.workingTime = DateTime.Parse(strArr[3]);
			this.defectRate = int.Parse(strArr[4]);
		}
	}
}
