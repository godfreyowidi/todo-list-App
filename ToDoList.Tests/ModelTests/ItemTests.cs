using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemsTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }
      [TestMethod]
      public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("tests");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

      [TestMethod]
      public void GetDescription_ReturnDescription_String()
    {
      string description = "walk the dog.";
      Item newItem = new Item(description);
      string result = newItem.Description;
      Assert.AreEqual(description, result);
    }

      [TestMethod]
      public void SetDescription_SetDescription_String()
    {
      string description = "walk the dog";
      Item newItem = new Item(description);

      string updatedDescription = "Do the dishes";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      Assert.AreEqual(updatedDescription, result);
    }

      [TestMethod]
      public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> newList = new List<Item> {};

      List<Item> result = Item.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}