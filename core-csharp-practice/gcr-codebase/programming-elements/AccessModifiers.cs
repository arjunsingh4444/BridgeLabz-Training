//private	(The code is only accessible within the same class)

class Car
{
  private string model = "Mustang";

  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}


//public	(The code is accessible for all classes)

class Car
{
  public string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}


//protected	  (The code is accessible within the same class, or in a class that is inherited from that class.)

class Parent
{
    protected int value = 100;
}

class Child : Parent
{
    void Display()
    {
        Console.WriteLine(value); // allowed
    }
}
//internal	(The code is accessible within the same assembly, but not from other assemblies.)

internal class InternalDemo
{
    public void Message()
    {
        Console.WriteLine("Internal Access");
    }
}

//protected internal	(The code is accessible within the same class, or in a class that is inherited from that class, or in a derived class that is in another assembly.)
class Parent
{
    protected internal int value = 100;
}

class Child : Parent
{
    void Display()
    {
        Console.WriteLine(value); // allowed
    }
}

//private protected	(The code is accessible within the same class, or in a class that is inherited from that class, or in a derived class that is in another assembly, but only within the same project.)

class Parent
{
    private protected int value = 100;
}

class Child : Parent
{
    void Display()
    {
        Console.WriteLine(value); // allowed
    }

}