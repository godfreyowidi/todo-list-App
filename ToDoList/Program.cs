using System.Collections.Generic;
using System;
namespace ToDoList.Models
{

  public class Program
  {
    public static void Main()
  {
    Console.WriteLine("Welcome to ToDoList.");
    while (true)
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? ");
      string input = Console.ReadLine();
      if (input == "add")
      {
        Console.WriteLine("What chore do you need to add to the list?");
        string chore = Console.ReadLine();
        Item newItem = new Item(chore);
        List<Item> newList = new List<Item> {newItem};
      
        Console.WriteLine(chore + " " + "has been added to your list.");
      }
      else 
      {
      
      List<Item> result = Item.GetAll();
      Console.WriteLine( "Total number to chores to complete = " + result.Count);
        if (result.Count == 0)
        {
          Console.WriteLine("Zero Items in the list");
          Console.ReadLine();
        }
        else
        {
          foreach( Item item in result)
          {
            Console.WriteLine(item.Description);
          }  
        }
      }
    }
  }
}
}