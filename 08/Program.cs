using System;

class Animal
{
  public virtual void Speak()
  {
    Console.WriteLine("Animal speaking...");
  }
}

class Dog : Animal
{
  public override void Speak()
  {
    Console.WriteLine("Woof! Woof!");
  }
}

class Cat : Animal
{
  public override void Speak()
  {
    Console.WriteLine("Meow!");
  }
}

class Program
{
  public static void Display(Animal animal)
  {
    animal.Speak();
  }

  static void Main(string[] args)
  {
    Dog dog = new Dog();
    Cat cat = new Cat();
    Display(dog);
    Display(cat);
  }
}
