using System;
using System.Text;
namespace ClassPropertyReader
{
   
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sb = ClassReader.Read(new Employee());
            Console.WriteLine(sb);
        
    }
    }
}


