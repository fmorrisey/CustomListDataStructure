using System;
using System.Dynamic;
using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] /// FLAGGED!!! /// INIT CHECKED dCC Inst MH
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

        [TestMethod] /// FLAGGED!!! /// INIT CHECKED dCC Inst MH
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

        [TestMethod] /// FLAGGED!!! /// INIT 
        public void Add_PositionOfItem_InPreExisitngArray()
        {
            // Purpose: What if I .Add to a list that has a 
            // couple things in it already (position of item)?

            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;   //Expected value at third index
            int actual;

            // Act
            testList.Add(1);    // 0
            testList.Add(2);    // 1
            testList.Add(3);    // 2
            actual = testList[2];       //the value at the third index should be 

            // Assert
            Assert.AreEqual(expected, actual); // Must be 3
        }

        [TestMethod] /// FLAGGED!!! /// INIT
        public void Add_ValueOfCount_InPreExsitingArray()
        {
            // Purpose: What if I .Add to a list that has a 
            // couple things in it already (value of count)?

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

        // Once you have three send to instructor

        [TestMethod] /// FLAGGED!!! ///
        public void Doubles_Capacity()
        {
            // Purpose/Goal: How does the capacity changes as you add things? (Starts at 4, and doubles?)
            CustomList<int> testList = new CustomList<int>();

            // Arrange
            int expected = 8;
            int actual;

            // Act
            for (int i = 0; i < 6; i++) // Count to 6, activate double capacity 
            {
                testList.Add(i);        // Adds the iterator to new array spots
                                        // This will force expander method to activate
                                        // at the 4 iteration to an 8 sized array capacity
            }

            actual = testList.Capcity;  //Returns the capacity value

            // Assert
            Assert.AreEqual(expected, actual);  // Value should be 8
        }

        [TestMethod] /// FLAGGED!!! ///
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

        [TestMethod]
        public void Remove_RemoveAMatchingItem_FromList()
        {

        }
    }
}
