using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvc_pattern.Model;

namespace mvc_pattern.Service.Scheduling
{
	interface SchedulingService
	{
		SchedulingModel getModelFromExcel(string path);
		SchedulingModel setSchedulingData(SchedulingModel model);
	}
}
