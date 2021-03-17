using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mvc_pattern.Model.Entity
{
	class Roulette
	{
		// 룰렛 적합도
		public List<double> fitness;
		// 전체 적합도의 합
		public double fitnessSum;
		
		public Roulette(List<Chromosome> chromosomes)
		{
			this.fitness = new List<double>();
			this.fitnessSum = 0.0;

			foreach(Chromosome ch in chromosomes)
			{
				this.fitness.Add(
					(chromosomes[499].useFit - ch.useFit) + 
					(chromosomes[499].useFit - chromosomes[0].useFit) / (3.0 - 1.0));

				this.fitnessSum += this.fitness[this.fitness.Count - 1];


				/*
				Console.WriteLine("룰렛 적합도 --- " + this.fitness[this.fitness.Count - 1]);
				Console.WriteLine("룰렛 전체 적합도 합 --- " + this.fitnessSum);
				Thread.Sleep(300);
				*/
			}
		}

		public List<int> spinWheel()
		{
			List<int> selectCh = new List<int>();

			do
			{
				Random rand = new Random(DateTime.Now.Millisecond);
				double sum = 0;
				double point = (rand.NextDouble() * (fitnessSum - 0)) + 0;

				for(int f = 0; f< this.fitness.Count; f++)
				{
					sum += this.fitness[f];
					if(point < sum)
					{
						if(selectCh.Contains(f))
						{
							break;
						} else
						{
							selectCh.Add(f);
						}
					}
				}
			} while (selectCh.Count < 2);

			// Console.WriteLine("선정된 인덱스 ===> " + selectCh[0] + "," + selectCh[1]);

			return selectCh;
		}
	}
}
