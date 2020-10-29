using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomListUnitTester
{
    /// <summary>
    /// Unit Testing created for Test Drive Development of for the
    /// CustomList<T> Generics data structure.
    /// 
    /// /// FLAGGED!!! /// == FAILED TEST / Broken Code
    /// /// PASSED!!! /// == PASSING TEST / Functional Code
    /// 
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        ///////////////// ADD METHODS UNIT TEST /////////////////
        [TestMethod] [AddMethodTests] /// PASSED!!! 
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 2;
            int expected = 2;
            int actual;

            // Act
            testList.Add(item);
            actual = testList[0]; // error expected until "indexer property" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [AddMethodTests] /// PASSED!!! ///
        public void Add_AddItemTwoIemsToList_CheckSecondItem()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item0 = 2;
            int item1 = 2;
            int expected = 2;
            int actual;

            // Act
            testList.Add(item0);
            testList.Add(item1);
            actual = testList[1]; // error expected until "indexer property" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [AddMethodTests] /// PASSED!!! ///
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 1;
            int expected = 1;
            int actual;

            // Act
            testList.Add(item);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [AddMethodTests] /// PASSED!!! ///
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

        [TestMethod] [AddMethodTests] /// PASSED!!! /// 
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


        ///////////////// CAPACITY AND COUNT UNIT TEST /////////////////

        [TestMethod]
        [AddMethodTests] /// PASSED!!! ///
        public void Doubles_Capacity()
        {
            // Purpose/Goal: How does the capacity changes as you add things? (Starts at 4, and doubles?)
            CustomList<int> testList = new CustomList<int>();

            // Arrange
            int expected = 8;
            int actual;

            // Act
            for (int i = 0; i < 5; i++) // Count to 5, activate double capacity 
            {
                testList.Add(i);        // Adds the iterator to new array spots
                                        // This will force expander method to activate
                                        // at the 4 iteration to an 8 sized array capacity
            }

            actual = testList.Size;  //Returns the capacity value

            // Assert
            Assert.AreEqual(expected, actual);  // Value should be 8
        }

        [TestMethod]
        [AddMethodTests] /// PASSED!!! ///
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
            Assert.AreEqual(expected, actual); // Must be 6
        }

        ///////////////// REMOVE UNIT TEST /////////////////
        [TestMethod] [RemoveMethodTests] /// PASSED!!! ///
        public void Remove_AtFirstIndex_FromList()
        {   // Remove before expander
            // Arrange //
            CustomList<int> removeList = new CustomList<int>();
            int expected = 1;
            int actual;

            // Act //
            for (int i = 0; i < 4; i++)
            {
                removeList.Add(i);
            }

            removeList.Remove(0);   // Remove at first 1 
            actual = removeList[0]; // Query at 1

            // Assert
            Assert.AreEqual(expected, actual); // must = 0

        }

        [TestMethod] [RemoveMethodTests] /// PASSED!!! ///
        public void Remove_RemoveAtSecond_FromList()
        {
            // Arrange // Remove before expander //

            //Create the list
            CustomList<int> removeList = new CustomList<int>();

            //Init vars
            int expected = 3;
            int actual;

            //Add to list
            removeList.Add(1);      // 0
            removeList.Add(2);      // 1 
            removeList.Add(3);      // 2 .Remove = 0
            removeList.Add(4);      // 3 

            removeList.Remove(1);   // Remove at 2
            actual = removeList[1]; // Query at 2

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public void Remove_RemoveITEM_FromList_CountGoesDown()
        {
            // Arrange // Remove before expander //

            //Create the list
            CustomList<int> removeList = new CustomList<int>();

            //Init vars
            int expected = 3;
            int actual;

            //Add to list
            removeList.Add(1);      // 0
            removeList.Add(2);      // 1 
            removeList.Add(3);      // 2 .Remove = 0
            removeList.Add(4);      // 3 

            removeList.Remove(2);   // Remove at i3
            actual = removeList.Count;// count changes from 4 to 3

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [RemoveMethodTests] /// PASSED!!! ///
        public void Remove_RemoveLastItem_FromList()
        {
            // Remove before expander
            // Arrange //
            CustomList<int> removeList = new CustomList<int>();
            int expected = 0;
            int actual;

            // Act //
            for (int i = 0; i < 4; i++)
            {
                removeList.Add(i);  // Add values to _capacity
            }                       // [0][1][2][3]

            removeList.Remove(3);   // Remove at 3
            actual = removeList[3]; // Query at 3

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [RemoveMethodTests] /// PASSED!!! ///
        public void Remove_RemoveAfterExpanderMethod_FromList()
        {
            // Remove before expander
            // Arrange //
            CustomList<int> removeList = new CustomList<int>();
            int expected = 7;
            int actual;

            // Act //
            for (int i = 0; i < 8; i++)
            {
                removeList.Add(i);  // Add values to _capacity 8
            }                       // [0][1][2][3][4][5][6][7]

            removeList.Remove(6);   // Remove at last index
            actual = removeList[6]; // Query at i7

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [RemoveMethodTests] /// PASSED!!! ///
        public void Remove_RemoveLastItem_FromList_AfterExpanderCycle()
        {
            // Remove after expander
            // Arrange //
            CustomList<int> removeList = new CustomList<int>();
            int expected = 0;
            int actual;

            // Act //
            for (int i = 0; i < 14; i++)
            {                           // creates a list with 14 values in
                removeList.Add(i);      // an array with a _capacity of i16
            }                           // [0][1][2][3][4][5][6][7]
                                        // [8][9][10][11][12][13][0][0]

            removeList.Remove(13);      // Remove at 13
            actual = removeList[13];    // Query at 13 or i14

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [RemoveMethodTests] /// PASSED!!! ///
        public void Remove_SearchAndRemoveItem()
        {
            // Remove before expander
            // Arrange //
            CustomList<int> removeList = new CustomList<int>();
            int expected = 0;
            int actual;
            int item = 2;

            // Act //
            for (int i = 0; i < 3; i++)
            {                           // creates a list with 3 values in
                removeList.Add(i);      // an array with a _capacity of i4
            }                           // [0][1][2][0]

            removeList.Remove(2);       // Search Remove at 2
            actual = removeList[2];     // Query at i2

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [RemoveMethodTests] /// PASSED!!! ///
        public void Remove_SearchAndRemove_MatchingString()
        {
            // Remove before expander
            // Arrange //
            CustomList<string> strList = new CustomList<string>();


            string expected = "Hello 2";
            string actual;

            // Act //

            for (int i = 0; i < strList.Size; i++)
            {
                string str = ($"Hello {i}");
                strList.Add(str);

            }

            strList.Remove("Hello 1");       // Search Remove at 1
            actual = strList[1];            // Query at index 1

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [RemoveMethodTests] /// PASSED!!! ///
        public void Remove_DoubleRemove()
        {
            // Remove before expander
            // Arrange //
            CustomList<int> removeList = new CustomList<int>();
            int expected = 5;
            int actual;


            // Act //
            for (int i = 1; i < 8; i++)
            {                           // creates a list with 3 values in
                removeList.Add(i);      // an array with a _capacity of i4
            }                           // [1][2][3][4][5][6][7][8]
                                        // [1][3][4][6][7][8][0][0]
                                        // [1][3][5][6][7][8][0][0]

            removeList.Remove(2);       // Search Remove at 2
            removeList.RemoveAt(2);     // Search Remove at 2
            actual = removeList[2];     // Query at i2

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [RemoveMethodTests] /// PASSED!!! ///
        public void Remove_SearchAndRemoveItem_AfterExpanderCycle()
        {
            // Remove after expander
            // Arrange //
            CustomList<int> removeList = new CustomList<int>();
            int expected = 5;
            int actual;
            int item = 4;

            // Act //
            for (int i = 0; i < 14; i++)
            {                           // creates a list with 14 values in
                removeList.Add(i);      // an array with a _capacity of i16
            }

            removeList.Remove(item);    // search Remove at 4
            actual = removeList[4];     // Query at 4
                                        // [0][1][2][3][5][6][0]
                                        // Assert //                    0  1  2  3  4  5  6
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [RemoveMethodTests] /// Passed!!! ///
        public void Remove_RemoveATIndex_List()
        {
            // Remove after expander
            // Arrange //
            CustomList<int> removeList = new CustomList<int>();
            int expected = 5;
            int actual;
            int item = 4;

            // Act //
            for (int i = 0; i < 14; i++)
            {                           // creates a list with 14 values in
                removeList.Add(i);      // an array with a _capacity of i16
            }

            removeList.RemoveAt(item);  // Remove at 4
            actual = removeList[4];     // Query at 4
                                        // [0][1][2][3][5][6][0]
                                        // Assert //             
            Assert.AreEqual(expected, actual);
        }

        ///////////////// ADD AND REMOVE COMBO UNIT TEST /////////////////

        [TestMethod] [RemoveMethodTests] [AddMethodTests] /// PASSED!!! ///
        public void Remove_Add_MultipleInstances_StressTest()
        {
            // Remove after expander
            // Arrange //
            CustomList<string> strList = new CustomList<string>();


            string expected = "Hello 3"; //Hello 3
            string actual;

            // Act //

            for (int i = 0; i < 6; i++)
            {
                string str = ($"Hello {i}");
                strList.Add(str);

            }

            strList.Remove("Hello 1");      // Search Remove at 1 replaced with Hello 2
            strList.Add("Add 1");           // Adds at 5th index
            strList.Remove("Hello 2");      // Search Remove at 1 replaced with Hello 3
            strList.Add("Add 2");           // Adds at 5th index
            actual = strList[1];            // Query at index 1

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] [RemoveMethodTests] [AddMethodTests] /// PASSED!!! ///
        public void Remove_Add_DuplicateItem()
        {
            // Remove After expander
            // Arrange //
            CustomList<string> strList = new CustomList<string>();


            string expected = "Hello 3"; //Hello 3
            string actual;

            // Act //

            for (int i = 0; i < 6; i++)
            {
                string str = ($"Hello {i}");
                strList.Add(str);

            }
            for (int i = 0; i < 6; i++)
            {

                string str = ($"Hello {i}");
                strList.Add(str);

            }

            strList.Remove("Hello 1");      // Search Remove at 1 replaced with Hello 2
            strList.Add("Add 1");           // Adds at 5th index
            strList.Remove("Hello 2");      // Search Remove at 1 replaced with Hello 3
            strList.Add("Add 2");           // Adds at 5th index
            actual = strList[1];            // Query at index 1


            // Assert
            Assert.AreEqual(expected, actual);
        }


        ///////////////// ITERABLITY TEST /////////////////
        [TestMethod][IterableTests] /// PASSED ///
        public void Iteraotr_ForEachInteger()
        {
            // Arrange
            int expected = 4;
            int actual;
            int counter = 0;
            CustomList<int> interIntList = new CustomList<int>();

            // Act
            foreach (var item in interIntList )
            {
                counter++;
                interIntList.Add(counter);
            }
            actual = interIntList[3];
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod][IterableTests] /// FAILED /// INCOMPLETE
        public void Iteraotr_Test1()
        {
            // Arrange
            int expected = 0;
            int actual;

            // Act
            ///SOME CODE HERE
            actual = 1;
            // Assert
            Assert.AreEqual(expected, actual);
        }


        ///////////////// PlusOperand TEST /////////////////
        [TestMethod]
        [PlusOperandTests] /// FAILED ///
        public void PlusOperand_Test0()
        {
            // Arrange
            int expected = 0;
            int actual;

            // Act
            ///SOME CODE HERE
            actual = 1;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [PlusOperandTests] /// FAILED ///
        public void PlusOperand_Test1()
        {
            // Arrange
            int expected = 0;
            int actual;

            // Act
            ///SOME CODE HERE
            actual = 1;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        ///////////////// MinusOperand TEST /////////////////
        [TestMethod]
        [MinusOperandTests] /// FAILED ///
        public void MinusOperand_Test0()
        {
            // Arrange
            int expected = 0;
            int actual;

            // Act
            ///SOME CODE HERE
            actual = 1;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [PlusOperandTests] /// FAILED ///
        public void MinusOperand_Test1()
        {
            // Arrange
            int expected = 0;
            int actual;

            // Act
            ///SOME CODE HERE
            actual = 1;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        ///////////////// Zipper TEST /////////////////
        [TestMethod]
        [ZipperTests] /// FAILED ///
        public void Zipper_Test0()
        {
            // Arrange
            int expected = 0;
            int actual;

            // Act
            ///SOME CODE HERE
            actual = 1;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ZipperTests] /// FAILED ///
        public void Zipper_Test01()
        {
            // Arrange
            int expected = 0;
            int actual;

            // Act
            ///SOME CODE HERE
            actual = 1;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        ///////////////// ToString TEST /////////////////
        [TestMethod]
        [ToStringTests] /// PASSED ///
        public void ToString_IntTOString()
        {
            // Arrange
            string expected = "01234567";
            string actual;
            CustomList<int> strList = new CustomList<int>();

            // Act
            for (int i = 0; i < 8; i++)
            {
                strList.Add(i);

            }

            actual = strList.ToString();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ToStringTests] /// PASSED ///
        public void ToString_DoubleToString()
        {
            string expected = "0120";
            string actual;
            double counter = 3.33d;
            CustomList<double> doubleList = new CustomList<double>();

            // Act
            for (int i = 0; i < 3; i++)
            {
                counter++;
                //counter = Math.Round(counter, 4);
                doubleList.Add(i);

            }

            actual = doubleList.ToString();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        ///////////////// SORT TEST /////////////////
        [TestMethod]
        [SortMethodTests] /// Passed ///
        public void Sort_Intergers_Test()
        {
            // Arrange // Controlled sort test with expected results
            int expected = 5;
            int actual;

            CustomList<int> sortListInt = new CustomList<int>();
            
            // Act
            sortListInt.Add(1); //0
            sortListInt.Add(7); //1
            sortListInt.Add(2); //2
            sortListInt.Add(5); //3

            sortListInt.Sort();
            actual = sortListInt[2];
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [SortMethodTests] /// PASSED ///
        public void Sort_Strings_Test()
        {
            // Arrange // Controlled sort test with expected results
            string expected = "ü"; //Der Deutsch Umlaute hast drietter gekommen 
            string actual;         //The German Umlaute comes third in this sort

            CustomList<string> sortListStrings = new CustomList<String>();

            // Act
            sortListStrings.Add("A"); //0
            sortListStrings.Add("z"); //1
            sortListStrings.Add("ü"); //2
            sortListStrings.Add("§"); //3

            sortListStrings.Sort();
            actual = sortListStrings[2];
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [SortMethodTests] /// FAIILED /// INCOMPLETE
        public void Sort_StringsMultiLingual_Test()
        {
            // Arrange // Controlled sort test with expected results
            string expected = "ü"; //Der Deutsch Umlaute hast drietter gekommen 
            string actual;         //The German Umlaute comes third in this sort

            CustomList<string> sortListStrings = new CustomList<String>();

            // Act
            sortListStrings.Add("A"); //0
            sortListStrings.Add("z"); //1
            sortListStrings.Add("ü"); //2
            sortListStrings.Add("§"); //3

            sortListStrings.Sort();
            actual = sortListStrings[2];
            // Assert
            Assert.AreEqual(expected, actual);
        }

        ///////////////// ATTRIBUTE TAGES /////////////////
        public class RemoveMethodTests : System.Attribute { }

        public class AddMethodTests : System.Attribute { }

        public class SortMethodTests : System.Attribute { }

        public class ToStringTests : System.Attribute { }
        
        public class PlusOperandTests : System.Attribute { }
        
        public class MinusOperandTests : System.Attribute { }
        
        public class IterableTests : System.Attribute { }
        
        public class ZipperTests : System.Attribute { }



    }
}
