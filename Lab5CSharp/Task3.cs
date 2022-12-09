using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp_Task3
{
    abstract class Person
    {
        virtual public string Name { get; set; }
        virtual public string SureName { get; set; }
        virtual public DateTime DateOfBirth { get; set; }
        virtual public uint Age
        {
            get 
            { 
                return (uint)(DateTime.UtcNow.Year - DateOfBirth.Year);
            }
        }
        virtual public void showInformation()
        {
            Console.Write($"Name: {Name}, Sure Name: {SureName}, Age: {Age}, Date Of Birth: {DateOfBirth.ToShortDateString()}");
        }
        public Person()
        {
            Name = string.Empty;
            SureName= string.Empty;
            DateOfBirth = DateTime.MinValue;
        }
        public Person(string name, string sureName, DateTime dateOfBirth)
        {
            Name = name;
            SureName = sureName;
            DateOfBirth = dateOfBirth;
        }
    }
    class Entrant : Person
    {
        public string Faculty { get; set; }
        public Entrant() : base()
        {
            
        }
        public Entrant(string name, string sureName, DateTime dateOfBirth, string faculty) : base(name, sureName, dateOfBirth)
        {
            Faculty = faculty;
        }
        public override void showInformation()
        {
            base.showInformation();
            Console.WriteLine($", Faculty: {Faculty}");
        }
    }
    class Student : Person
    {
        public string Faculty { get; set; }
        public uint Course { get; set; }
        public Student() : base()
        {

        }
        public Student(string name, string sureName, DateTime dateOfBirth, string faculty, uint course) : base(name, sureName, dateOfBirth)
        {
            Faculty = faculty;
            Course = course;
        }
        public override void showInformation()
        {
            base.showInformation();
            Console.WriteLine($", Faculty: {Faculty}, Course: {Course}");
        }
    }
    class Teacher : Person
    {
        public string Faculty { get; set; }
        public string Post { get; set; }
        public string Experience { get; set; }
        public Teacher() : base()
        {

        }
        public Teacher(string name, string sureName, DateTime dateOfBirth, string faculty, string post, string experience) : base(name, sureName, dateOfBirth)
        {
            Faculty = faculty;
            Post = post;
            Experience = experience;
        }
        public override void showInformation()
        {
            base.showInformation();
            Console.WriteLine($", Faculty: {Faculty}, Post: {Post}, Experience: {Experience}");
        }
    }
}
