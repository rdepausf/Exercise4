using System;
namespace Day_4_in_class
{
    //class Pig : Animal  // Derived class (child) 
    //{
    //    public override void animalSound()
    //    {
    //        Console.WriteLine("The pig says: wee wee");
    //    }
    //}

    //Interface

    class Pig : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }

        public void run()
        {
            throw new NotImplementedException();
        }
    }
}
