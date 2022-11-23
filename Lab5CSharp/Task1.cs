using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp
{
    abstract class Organization
    {
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Classification { get; set; }
        public Organization()
        {
            Name = "empty";
            Address = "empty";
            Classification = "empty";
        }
        public Organization(string name, string address, string classification)
        {
            Name = name;
            Address = address;
            Classification = classification;
        }
        public virtual void show() => Console.Write($"{this.GetType().Name}:  Name: {Name}  Address: {Address}  Classification: {Classification}  ");
    }
    class InsuranceCompany : Organization
    {
        public string TypeProperty { get; set; }
        public InsuranceCompany()
        {
            TypeProperty = "empty";
        }
        public InsuranceCompany(string name, string address, string classification, string typeProperty) : base(name, address, classification)
        {
            TypeProperty = typeProperty;
        }
        public new void show()
        {
            base.show();
            Console.Write($"Type of Property: {TypeProperty}");
        }
    }
    class Plant : Organization
    {
        public string Owner { get; set; }
        public Plant()
        {
            Owner = "empty";
        }
        public Plant(string name, string address, string classification, string owner) : base(name, address, classification)
        {
            Owner = owner;
        }
        public new void show()
        {
            base.show();
            Console.Write($"Owner: {Owner}");
        }
    }
    class OilGasCompany : Organization
    {
        public string NumberPumpingStations { get; set; }
        public string NumberGasProcessingPlants { get; set; }
        public string Owner { get; set; }
        public OilGasCompany()
        {
            Owner = "empty";
            NumberPumpingStations = "empty";
            NumberGasProcessingPlants = "empty";
        }
        public OilGasCompany(string name, string address, string classification, string owner, string numberPumpingStations, string numberGasProcessingPlants) : base(name, address, classification)
        {
            Owner = owner;
            NumberPumpingStations = numberPumpingStations;
            NumberGasProcessingPlants = numberGasProcessingPlants;
        }
        public new void show()
        {
            base.show();
            Console.Write($"Owner: {Owner} The number pumping stations: {NumberPumpingStations} The number gas processing plants: {NumberGasProcessingPlants}");
        }
    }
}
