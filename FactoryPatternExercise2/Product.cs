using System;
namespace FactoryPatternExercise2
{
	public class Product : IDataAccess
	{
		public string Name { get; set; }
		public int Price { get; set; }
	}
}

