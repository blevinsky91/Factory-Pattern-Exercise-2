using System;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
        public static void LoadData()
        {
            Console.WriteLine($"I am reading data from {ListDataAccess}");
        }

        public static void SaveData()
        {
            Console.WriteLine($"I am saving data from a {ListDataAccess} database");
        }
    }
}

