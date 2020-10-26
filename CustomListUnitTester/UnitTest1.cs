using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            // Arrange
            CustomList<int> = testList = new CustomList<int>();

            int item = 10;
            int expected = 1;
            int actual;

            // Act
            testList.Add(item);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);

        }
        // what if I .Add to a list that has a couple things in it already (position of item)?
        // what if I .Add to a list that has a couple things in it already (value of count)?
        // how does the capacity changes as you add things? (Starts at 4, and doubles?)
        // Once you have three send to instructor
    }
}
