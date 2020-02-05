using System;
namespace Day_4_in_class
{
    class Dog : IAnimal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }

        public void run()
        {
            throw new NotImplementedException();
        }
    }
}
