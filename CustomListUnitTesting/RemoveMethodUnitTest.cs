using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListBuild;

namespace CustomListUnitTesting
{
    [TestClass]
    class RemoveMethodUnitTest
    {
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
        
        [TestMethod]
          public void Remove_Item_Check_NewCurretIndex()
        {
            //Arrange
            CustomList<int> itemsToRemove = new CustomList<int>();
            int number1 = 4;
            int number2 = 5;
            int number3 = 6;
            int number4 = 7;
            int expected = 6;
            int actual;

            //Act
            itemsToRemove.Add(number1);
            itemsToRemove.Add(number2);
            itemsToRemove.Add(number3);
            itemsToRemove.Add(number4);
            itemsToRemove.Remove(number2);

            actual = itemsToRemove[1];

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Remove_ThreeItems_Check_NewIndex()
        {
            //Arrange
            CustomList<int> itemsToRemove = new CustomList<int>();
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            int number6 = 6;
            int number7 = 7;
            int expected = 6;
            int actual;

            //Act
            itemsToRemove.Add(number1);
            itemsToRemove.Add(number2);
            itemsToRemove.Add(number3);
            itemsToRemove.Add(number4);
            itemsToRemove.Add(number5);
            itemsToRemove.Add(number6);
            itemsToRemove.Add(number7);
            itemsToRemove.Remove(number2);
            itemsToRemove.Remove(number3);
            itemsToRemove.Remove(number4);

            actual = itemsToRemove[2];
   
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_Item_NotAvailable()
        {
            CustomList<int> itemsToRemove = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int expected;
            int actual;

            //Act
            itemsToRemove.Add(item1);
            itemsToRemove.Add(item2);
            itemsToRemove.Add(item3);
            itemsToRemove.Remove(item3);
            itemsToRemove.Remove(item3);


            actual;


            //Assert
            Assert.AreEqual();
        }

    }

}
