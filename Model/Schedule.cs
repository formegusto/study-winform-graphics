using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_winform_graphics.Model
{
	class Schedule
	{
		public string furnace { get; set; }
		public string lot { get; set; }
		public DateTime startTime { get; set; }
		public DateTime endTime { get; set; }
		public int workVolume { get; set; }
		public int restVolume { get; set; }

		Schedule() { }

		public Schedule(string[] line)
		{
			this.furnace = line[0];
			this.lot = line[1];
			this.startTime = DateTime.Parse(line[2]);
			this.endTime = DateTime.Parse(line[3]);
			this.workVolume = int.Parse(line[4]);
			this.restVolume = int.Parse(line[5]);
		}

		public void toString()
		{
			Console.WriteLine("용해로 ===> " + this.furnace);
			Console.WriteLine("제품 ===> " + this.lot);
			Console.WriteLine("시작시간 ===> " + this.startTime);
			Console.WriteLine("끝난시간 ===> " + this.endTime);
			Console.WriteLine("작업량 ===> " + this.workVolume);
			Console.WriteLine("잔량 ===> " + this.restVolume);
		}
	}
}
