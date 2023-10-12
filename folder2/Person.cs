using System;
namespace DevTest
{
    internal class Person
    {
      string _name;
      string _lastName;
      public void Show()
      {
        Console.WriteLine($"I am {_name} {_lastName}");
      }
    }
}
