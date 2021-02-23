using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListBuild;

namespace CustomListUnitTesting
{
    [TestClass]
    public class AddMethodUnitTest
    {

        // checking the index of the item on your CustomList<T> to make sure it was added
        // check the count of the list to see if it was added
        // check the capacity of our list to make sure it increases when we add an item beyond the original capacity
        [TestMethod]
        public void Add_Item_IncreaseCount_ByOne()
        {
            //Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            int number = 8;
            int expected = 1;
            int actual;

            //Act
            collectionOfNumbers.Add(number);
            actual = collectionOfNumbers.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Add5Itesm_IncreaseCapacity_At8()//Duplicate setup: Test 5th thing at index 4, test Count of 5, test to see one original item still persists
        {
            //Arrange
            CustomList<int> collectionofNumbers = new CustomList<int>();
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            int expected = 8;
            int actual;

            // Act
            collectionofNumbers.Add(number1);
            collectionofNumbers.Add(number2);
            collectionofNumbers.Add(number3);
            collectionofNumbers.Add(number4);
            collectionofNumbers.Add(number5);
            actual = collectionofNumbers.Capacity;
          
            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_Check_At_IndexOf_0()
        {

            //Arrange
            CustomList<int> indexOfNumbers = new CustomList<int>();
            int number = 7;
            int expected = 7;
            int actual;

            // Act
            indexOfNumbers.Add(number);

            actual = indexOfNumbers[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Items_IncreaseBy_Two()//Ad second item, test count, test index
        {

            // Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            int number1 = 3;
            int number2 = 4;
            int expected = 2;
            int actual;

            // Act
            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Add(number2);
            actual = collectionOfNumbers.Count;

            // Assert 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Items_IncreaseBy_Five()//test Count of 5
        {

            // Arrange
            CustomList<int> collectionOfNumbers = new CustomList<int>();
            int number1 = 6;
            int number2 = 7;
            int number3 = 8;
            int number4 = 9;
            int number5 = 10;
            int expected = 5;
            int actual;

            // Act
            collectionOfNumbers.Add(number1);
            collectionOfNumbers.Add(number2);
            collectionOfNumbers.Add(number3);
            collectionOfNumbers.Add(number4);
            collectionOfNumbers.Add(number5);
            actual = collectionOfNumbers.Count;

            // Assert 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Check_At_IndexOf_4() // Test 5th thing at index 4
        {

            //Arrange
            CustomList<int> indexOfNumbers = new CustomList<int>();
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            int expected = 5;
            int actual;

            // Act
            indexOfNumbers.Add(number1);
            indexOfNumbers.Add(number2);
            indexOfNumbers.Add(number3);
            indexOfNumbers.Add(number4);
            indexOfNumbers.Add(number5);

            actual = indexOfNumbers[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CheckToSee_OriginalNumberAfter_IncreasedCapacity() //test to see one original item still persists
        {
            // Arrange
            CustomList<int> indexOfNumbers = new CustomList<int>();
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            int number6 = 6;
            int number7 = 7;
            int expected = 2;
            int actual;

            //Act 

            indexOfNumbers.Add(number1);
            indexOfNumbers.Add(number2);
            indexOfNumbers.Add(number3);
            indexOfNumbers.Add(number4);
            indexOfNumbers.Add(number5);
            indexOfNumbers.Add(number6);
            indexOfNumbers.Add(number7);

            actual = indexOfNumbers[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
