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

    [TestMethod]
    public void GetAll_ReturnItems_ItemList()
    {
      string description1 = "walk the dog";
      string description2 = "wash the dishes";
      Item newItem1 = new Item(description1);
      Item newItem2 = new Item(description2);
      List<Item> newList = new List<Item> {newItem1, newItem2};

      List<Item> result = Item.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}