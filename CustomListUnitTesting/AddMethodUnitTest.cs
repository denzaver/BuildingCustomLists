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

    }
}
