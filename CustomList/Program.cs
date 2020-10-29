using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> result = one + two; // result = 1,3,5,2,4,6
            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



            /*
            CustomList<int> sortListInt = new CustomList<int>();
            CustomList<int> sortListIntNEW = new CustomList<int>();
            CustomList<string> sortListStr = new CustomList<string>();
            RandomNumGen rand = new RandomNumGen();
            int randInt = 0;
            string randStr = "";

            for (int i = 0; i < 18; i++)
            {
                randInt = rand.GenerateRandomInt(0, 32);
                sortListInt.Add(randInt);
            }

            sortListInt.Sort();
            foreach (var val in sortListInt)
            {
                Console.WriteLine($"Print: {val}");
            }
            Console.ReadLine();

            for (int i = 0; i < 32; i++)
            {
                randStr = rand.GenerateRandomString();
                sortListStr.Add(randStr);
            }

            sortListStr.Sort();
            foreach (var val in sortListStr)
            {
                Console.WriteLine($"Print: {val}");
            }
            Console.ReadLine();

            /*
            string expected = "01234567";
            string actual;
            CustomList<int> intListToString = new CustomList<int>();

            // Act
            for (int i = 0; i < 8; i++)
            {
                intListToString.Add(i);

            }

            actual = intListToString.ToString();
            
            CustomList<string> strList = new CustomList<string>();
            string actualSTR = "";
                        
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
            actualSTR = strList[1];            // Query at index 1


            foreach (var str in strList)
            {
                Console.WriteLine($"Print: {str}");
            }
            Console.Read();

            CustomList<EngineType> engineList = new CustomList<EngineType>();
            
            for (int i = 0; i < 5; i++)
            {
                engineList.Add(new EngineType("RL-10cx"));
                
            }
            
            CustomList<int> addList = new CustomList<int>();
            
            for (int i = 0; i < 5; i++)
            {
                addList.Add(i);
            }
            

            CustomList<int> removeList = new CustomList<int>();

            for (int i = 0; i < 16; i++)
            {
                removeList.Add(i);
            }

            removeList.Remove(5);
            removeList.RemoveAt(5);
            

            Console.WriteLine("");
            
            */


        }
    }
}
