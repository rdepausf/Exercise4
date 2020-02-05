using System;
namespace Day_4_in_class
{
    //Polymorphism
    //class Animal  // Base class (parent) 
    //{
    //    public virtual void animalSound()
    //    {
    //        Console.WriteLine("The animal makes a sound");
    //    }
    //}


    //abstract class Animal
    //{
    //    public abstract void animalSound();
    //    public void sleep()
    //    {
    //        Console.WriteLine("Zzz");
    //    }
    //}


    //Animal myObj = new Animal();

    public interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
        void run(); // interface method (does not have a body)
    }


}
