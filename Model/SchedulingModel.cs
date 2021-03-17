using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvc_pattern.Model.Entity;

namespace mvc_pattern.Model
{
	class SchedulingModel
	{
		public List<Furnace> furnaces;
		public List<Product> products;
		public List<Order> orders;
		public Genetic genetic;
		public List<Chromosome> elites;
		public List<Chromosome> chromosomes;
		public Roulette roulette;

		public SchedulingModel()
		{
			this.furnaces = new List<Furnace>();
			this.products = new List<Product>();
			this.orders = new List<Order>();
			this.chromosomes = new List<Chromosome>();
		}

		public void setGenetic()
		{
			this.genetic = new Genetic(this, 500, 25, 0.05);
		}

		public void setRoulette()
		{
			this.roulette = new Roulette(this.chromosomes);
		}
	}
}
