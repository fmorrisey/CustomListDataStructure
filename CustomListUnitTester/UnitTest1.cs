using System;
using System.Dynamic;
using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 10;
            int actual;

            // Act
            testList.Add(item);
            actual = testList[0]; // error expected until "indexer property" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 1;
            int actual;

            // Act
            testList.Add(item);
            actual = testList.Count; // error expected until "Count" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemTo_PreExisitngArray() /// FLAGGED!!! ///
        {
            // What if I .Add to a list that has a couple things in it already (position of item)?
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 1;
            int actual;

            // Act
            testList.Add(item);
            actual = testList.Count; // error expected until "Count" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemTo_PreExsitingArray() /// FLAGGED!!! //
        {
            // What if I .Add to a list that has a couple things in it already (value of count)?
            
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 1;
            int actual;

            // Act
            testList.Add(item);
            actual = testList.Count; // error expected until "Count" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // How does the capacity changes as you add things? (Starts at 4, and doubles?)
        // Once you have three send to instructor

        [TestMethod]
        public void SetsCount_Capacity_ThenCheck()
        {

        }

        [TestMethod]
        public void Count_ItterateThruListForCount()
        {
            // Arrange
            
            //Create the list
            CustomList<int> countList = new CustomList<int>();
            //init vars
            int expected = 6;
            int actual;
            //add to list
            countList.Add(0);
            countList.Add(1);
            countList.Add(2);
            countList.Add(3);
            countList.Add(4);
            countList.Add(5);
            

            // Act
            actual = countList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }


        // REMOVE TESTS:
    }
}
