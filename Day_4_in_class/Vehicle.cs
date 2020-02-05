using System;
namespace Day_4_in_class
{
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
