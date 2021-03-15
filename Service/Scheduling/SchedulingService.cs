using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_pattern.Service.Scheduling
{
	public interface SchedulingService
	{
		void setDataFromExcel(string path);
	}
}
