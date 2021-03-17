using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mvc_pattern.Model.Entity
{
	class Gene
	{
		public int furnaceIdx;
		public int orderIdx;

		public Gene(int furnaceIdx, int orderIdx)
		{
			this.furnaceIdx = furnaceIdx;
			this.orderIdx = orderIdx;
		}
	}
	class Chromosome
	{
		public int useFit;
		public List<Gene> genes;

		public Chromosome(SchedulingModel model)
		{
			int furnaceIdx;
			int orderIdx;

			this.genes = new List<Gene>();
			List<Furnace> furnaces = model.furnaces;

			for (int g = 0; g < model.genetic.geneLength; g++)
			{
				Random rand = new Random(DateTime.Now.Millisecond);

				// 용해로를 우선 랜덤하게 뽑고,
				furnaceIdx = rand.Next(0, furnaces.Count);

				// 뽑힌 용해로가 만들 수 있는 제품 Idx를 뽑는다.
				orderIdx = rand.Next(0, furnaces[furnaceIdx].furnaceScheduling.ableOrder.Count);

				genes.Add(new Gene(furnaceIdx, orderIdx));
			}
		}

		public void calcFit(SchedulingModel model)
		{
			List<Furnace> furnaces = model.furnaces.ConvertAll(f => new Furnace(f));
			List<Product> products = model.products.ConvertAll(p => new Product(p));
			
			foreach (Gene gene in genes)
			{
				// 남은 제품이랑 끝난 시간을 구해야 한다.
				Furnace furnace = furnaces[gene.furnaceIdx];
				Order order = furnace.furnaceScheduling.ableOrder[gene.orderIdx];
				Product product = products.Find(p => p.name == order.name);

				// 1. 주조 후에는 잔량이 내려간다.
				// 주조를 해도 되는 상황
				if ((furnace.furnaceScheduling.productionVolume + product.workingVolume) > furnace.volume)
				{
					// 볼륨 채우기
					furnace.restVolume = furnace.furnaceScheduling.productionVolume;
					// Console.WriteLine(furnace.name + "이 제품 생산을 위해 용해를 시작합니다.");
					// Thread.Sleep(1000);

					// 주조
					Product previousProduct = null;
					for(int g = 0; g < furnace.furnaceScheduling.orderBak.Count; g++)
					{
						Order productOrder = furnace.furnaceScheduling.ableOrder[
							furnace.furnaceScheduling.orderBak[g]
						];

						// 금형 교체	
						if (g != 0 && !previousProduct.name.Equals(productOrder.name))
						{
							// Console.WriteLine(furnace.name + "이 금형교체를 시작합니다.");
							// Thread.Sleep(1000);
						}
						previousProduct = products.Find(p => p.name == productOrder.name);

						// Console.WriteLine(furnace.name + "이 " + productOrder.name + " 생산을 시작합니다.");
						// Thread.Sleep(1000);

						// 남은 수량 줄이기 (제품 요구 수량 및 잔량)
						Product currentProduct = previousProduct;
						currentProduct.productScheduling.setQuantity();
						furnace.restVolume -= currentProduct.workingVolume;
					}

					// 마무리 클리어
					furnace.furnaceScheduling.setOrderBak(0, true);
					furnace.furnaceScheduling.productionVolume = 0;
				}

				furnace.furnaceScheduling.productionVolume += product.workingVolume;
				furnace.furnaceScheduling.setOrderBak(gene.orderIdx);

				// Thread.Sleep(1000);
			}

			// 적합도 계산
			
			foreach (Product p in products)
			{
				useFit += (p.productScheduling.requiredQuantity < 0) ? p.productScheduling.requiredQuantity * (-1) : p.productScheduling.requiredQuantity;
				//Console.WriteLine(p.name + " : 목표 수량 - " + p.productScheduling.quantity +", 남은 수량 - " + p.productScheduling.requiredQuantity);
			}
			/*
			// Console.WriteLine("====================");
			Thread.Sleep(500);
			*/
		}

		public void print(SchedulingModel model)
		{
			List<Furnace> furnaces = model.furnaces.ConvertAll(f => new Furnace(f));
			List<Product> products = model.products.ConvertAll(p => new Product(p));

			foreach (Gene gene in genes)
			{
				// 남은 제품이랑 끝난 시간을 구해야 한다.
				Furnace furnace = furnaces[gene.furnaceIdx];
				Order order = furnace.furnaceScheduling.ableOrder[gene.orderIdx];
				Product product = products.Find(p => p.name == order.name);

				// 1. 주조 후에는 잔량이 내려간다.
				// 주조를 해도 되는 상황
				if ((furnace.furnaceScheduling.productionVolume + product.workingVolume) > furnace.volume)
				{
					// 볼륨 채우기
					furnace.restVolume = furnace.furnaceScheduling.productionVolume;
					// Console.WriteLine(furnace.name + "이 제품 생산을 위해 용해를 시작합니다.");
					// Thread.Sleep(1000);

					// 주조
					Product previousProduct = null;
					for (int g = 0; g < furnace.furnaceScheduling.orderBak.Count; g++)
					{
						Order productOrder = furnace.furnaceScheduling.ableOrder[
							furnace.furnaceScheduling.orderBak[g]
						];

						// 금형 교체	
						if (g != 0 && !previousProduct.name.Equals(productOrder.name))
						{
							// Console.WriteLine(furnace.name + "이 금형교체를 시작합니다.");
							// Thread.Sleep(1000);
						}
						previousProduct = products.Find(p => p.name == productOrder.name);

						// Console.WriteLine(furnace.name + "이 " + productOrder.name + " 생산을 시작합니다.");
						// Thread.Sleep(1000);

						// 남은 수량 줄이기 (제품 요구 수량 및 잔량)
						Product currentProduct = previousProduct;
						currentProduct.productScheduling.setQuantity();
						furnace.restVolume -= currentProduct.workingVolume;
					}

					// 마무리 클리어
					furnace.furnaceScheduling.setOrderBak(0, true);
					furnace.furnaceScheduling.productionVolume = 0;
				}

				furnace.furnaceScheduling.productionVolume += product.workingVolume;
				furnace.furnaceScheduling.setOrderBak(gene.orderIdx);

				// Thread.Sleep(1000);
			}

			foreach (Product p in products)
			{
				Console.WriteLine("[" + this.useFit + "]" + p.name + " : 목표 수량 - " + p.productScheduling.quantity + ", 남은 수량 - " + p.productScheduling.requiredQuantity);
			}


		}
	}
}
