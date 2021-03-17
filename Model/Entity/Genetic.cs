using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_pattern.Model.Entity
{
	class Genetic
	{
		public int population;
		public int geneLength;
		public int eliteCount;
		public double rateMutation;

		public Genetic(SchedulingModel model, int population,int eliteCount, double rateMutation)
		{
			this.geneLength = model.products.Sum(product => product.productScheduling.requiredQuantity);
			this.population = population;
			this.eliteCount = eliteCount;
			this.rateMutation = rateMutation;
		}

		public Genetic(int geneLength, int eliteCount, double rateMutation)
		{
			this.geneLength = geneLength;
			this.eliteCount = eliteCount;
			this.rateMutation = rateMutation;
		}
	}
}
