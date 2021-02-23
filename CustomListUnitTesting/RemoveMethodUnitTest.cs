using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListBuild;

namespace CustomListUnitTesting
{
    [TestClass]
    class RemoveMethodUnitTest
    {
        // checking the index of the item on your CustomList<T> to make sure it was removed
        // check the count of the list to see if it was removed
        // check the capacity of our list to make sure it decreased when we add an item beyond the original capacity??
        [TestMethod]
        public void Remove_Item_DecreaseCount_ByOne()
        {
            // Arrange
            CustomList<int> itemsToRemove = new CustomList<int>(); //removes 1 item of 2, checks count
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int expected = 2;
            int actual;

            // Act
            itemsToRemove.Add(number1);
            itemsToRemove.Add(number2);
            itemsToRemove.Add(number3);
            itemsToRemove.Remove(number2);
            actual = itemsToRemove.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Item_DecreaseCount_ByTwo()
        {
            //Arrange
            CustomList<int> itemsToRemove = new CustomList<int>(); //removed 2 items, checks count
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int expected = 2;
            int actual;

            //Act
            itemsToRemove.Add(number1);
            itemsToRemove.Add(number2);
            itemsToRemove.Add(number3);
            itemsToRemove.Add(number4);
            itemsToRemove.Remove(number1);
            itemsToRemove.Remove(number4);
            actual = itemsToRemove.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Item_Check_Capacity() //removes the 5th item, checks capacity
        {
            //Arrange
            CustomList<int> itemsToRemove = new CustomList<int>();
            int number1 = 2;
            int number2 = 3;
            int number3 = 4;
            int number4 = 5;
            int number5 = 6;
            int expected = 8;
            int actual;

            //Act
            itemsToRemove.Add(number1);
            itemsToRemove.Add(number2);
            itemsToRemove.Add(number3);
            itemsToRemove.Add(number4);
            itemsToRemove.Add(number5);
            itemsToRemove.Remove(number5);
            actual = itemsToRemove.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }


    }

}
