using Lab5CSharp;

Console.WriteLine("Lab5 C# Demenchuk Dmytro");
void testTask1()
{
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





