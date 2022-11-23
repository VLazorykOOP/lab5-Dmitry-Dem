

Console.WriteLine("Lab5 C# Demenchuk Dmytro");

//Lab5CSharp_Task1.Task1.testTask1();

Lab5CSharp_Task2.Task2.testTask2();

GC.Collect();

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


