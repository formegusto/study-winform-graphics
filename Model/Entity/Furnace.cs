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
		public int volume;
		public int restVolume;
		public DateTime previousWorkTime;
		public DateTime meltingTime;
		public DateTime holdingTime;
		public int holdingKw;
		public int workingKw;

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
	}
}
