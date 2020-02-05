using System;

namespace Day_4_in_class
{
    //car class for classes/objects 
    //class Car
    //{
    //    //string color = "red"
    //    public string color = "red";

    //static void Main(string[] args)
    //    //{
    //    //    Car myObj1 = new Car();
    //    //    Car myObj2 = new Car();
    //    //    Console.WriteLine(myObj1.color);
    //    //    Console.WriteLine(myObj2.color);
    //    //}
    //}

    // car class for class members

    //class Car
    //{
    //    string model;
    //    string color;
    //    int year;

    //    static void Main(string[] args)
    //    {
    //        Car Ford = new Car();
    //        Ford.model = "Mustang";
    //        Ford.color = "red";
    //        Ford.year = 1969;

    //        Car Opel = new Car();
    //        Opel.model = "Astra";
    //        Opel.color = "white";
    //        Opel.year = 2005;

    //        Console.WriteLine(Ford.model);
    //        Console.WriteLine(Opel.model);
    //    }
    //}

    //class Car
    //{
    //    string color;                 // field
    //    int maxSpeed;                 // field
    //    public void fullThrottle()    // method
    //    {
    //        Console.WriteLine("The car is going as fast as it can!");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Car myObj = new Car();
    //        myObj.fullThrottle();  // Call the method
    //    }
    //}

    //class Car
    //{
    //    public string model;
    //    public string color;
    //    public int year;
    //    public void fullThrottle()
    //    {
    //        Console.WriteLine("The car is going as fast as it can!");
    //    }
    //}


    //Constructor

    //class Car
    //{
    //    public string model;
    //    public string color;
    //    public int year;

    //    // Create a class constructor with multiple parameters
    //    public Car(string modelName, string modelColor, int modelYear)
    //    {
    //        model = modelName;
    //        color = modelColor;
    //        year = modelYear;
    //    }

    //    //static void Main(string[] args)
    //    //{
    //    //    Car Ford = new Car("Mustang", "Red", 1969);
    //    //    Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
    //    //}
    //}

    // Access Modifiers

    //class Car
    //{
    //    //private string model;

    //    //public Car(string model)
    //    //{
    //    //    this.model = model;
    //    //}

    //    public string model = "Mustang";

    //    //static void Main(string[] args)
    //    //{
    //    //    Car Ford = new Car("Mustang");
    //    //    Console.WriteLine(Ford.model);
    //    //}
    //}

    // Inheritance

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }

}
