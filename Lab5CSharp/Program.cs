Console.WriteLine("Lab5 C# Demenchuk Dmytro");

Lab5CSharp_Task1.Task1.testTask1();
GC.Collect();

Lab5CSharp_Task2.Task2.testTask2();
GC.Collect();

Lab5CSharp_Task3.Task3.testTask3();

namespace Lab5CSharp_Task1
{
	class Task1
	{
		public static void testTask1()
		{
			Console.WriteLine("Task 1");

			Console.WriteLine("\n\nInsuranceCompany Enter: Name, Address, Classification, Type of Property");
			InsuranceCompany ins = new InsuranceCompany(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
			ins.show();

			Console.WriteLine("\n\nPlant Enter: Name, Address, Classification, Owner");
			Plant plt = new Plant(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
			plt.show();

			Console.WriteLine("\n\nOilGasCompany Enter: Name, Address, Classification, Owner, The number pumping stations, The number gas processing plants");
			OilGasCompany ogc = new OilGasCompany(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
			ogc.show();

			Console.WriteLine("\n\n");
		}
	}
}
namespace Lab5CSharp_Task2
{
	class Task2
	{
		public static void testTask2()
		{
			Console.WriteLine("Task 2");

			Console.WriteLine("\n\nInsuranceCompany Enter: Name, Address, Classification, Type of Property");
			InsuranceCompany ins = new InsuranceCompany(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
			ins.show();

			Console.WriteLine("\n\nPlant Enter: Name, Address, Classification, Owner");
			Plant plt = new Plant(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
			plt.show();

			Console.WriteLine("\n\nOilGasCompany Enter: Name, Address, Classification, Owner, The number pumping stations, The number gas processing plants");
			OilGasCompany ogc = new OilGasCompany(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
			ogc.show();

			Console.WriteLine("\n\n");
		}
	}
}
namespace Lab5CSharp_Task3
{
	class Task3
	{
		private static void showPersonsWhoseAgeFallsIntoGivenRange(in IEnumerable<Person> persons, DateTime startDate, DateTime endDate)
		{
			Console.WriteLine($"\nPersons whose age falls into a given range ({startDate.ToShortDateString()}-{endDate.ToShortDateString()}): ");
			foreach (var person in persons)
			{
				if (person.DateOfBirth >= startDate && person.DateOfBirth <= endDate)
				{
					person.showInformation();
				}
			}
		}
		public static void testTask3()
		{
			Console.WriteLine("Task 3");

			List<Person> persons = new List<Person>
			{
				new Entrant("Dmytro", "1", new DateTime(2003, 1, 1), "faculty 1"),
				new Student("Volodymyr", "2", new DateTime(2002, 1, 1), "faculty 2", 2),
				new Teacher("Anastasia", "3", new DateTime(2001, 1, 1), "faculty 3", "post 3", "exp 3")
			};

			foreach (var person in persons)
			{
				person.showInformation();
			}

			showPersonsWhoseAgeFallsIntoGivenRange(persons, new DateTime(2002, 1, 1), new DateTime(2003, 1, 1));

			Console.WriteLine("\n\n");
		}
	}
}