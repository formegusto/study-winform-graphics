using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvc_pattern.View;
using mvc_pattern.Model;
using mvc_pattern.Service.Scheduling;

namespace mvc_pattern.Controller
{
	public class SchedulingController
	{
		public SchedulingView view;
		public SchedulingModel model;
		public SchedulingService service;

		public SchedulingController()
		{
			this.view = new SchedulingView()
			{
				controller = this
			};
			this.model = new SchedulingModel();
			this.service = new SchedulingServiceImpl();
		}

		public void setDataFromExcel(string path)
		{
			this.service.setDataFromExcel(path);
		}
	}
}
