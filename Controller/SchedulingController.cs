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
	class SchedulingController
	{
		public SchedulingView view;
		public SchedulingModel model;
		SchedulingService service;

		public SchedulingController()
		{
			this.view = new SchedulingView() {
				controller = this
			};
			this.model = new SchedulingModel();
			this.service = new SchedulingServiceImpl();
		}

		public void setDataFromExcel(string path)
		{
			this.model = this.service.getModelFromExcel(path);
			this.view.setListView();
		}

		public void makeScheduling()
		{
			this.model = this.service.setSchedulingData(this.model);
			this.view.makeSchedulingSuccess();
		}
	}
}
