using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_pattern.Model
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
	}
}
