using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomList<string> strList = new CustomList<string>();
            string actualSTR = "";

            for (int i = 0; i < 6; i++)
            {
                string str = ($"Hello {i}");
                strList.Add(str);

            }

            strList.Remove("Hello 1");      // Search Remove at _
            strList.Add("Add 1");           // Search Remove at _
            strList.Remove("Hello 2");      // Search Remove at _
            strList.Add("Add 2");           // Search Remove at _
            actualSTR = strList[1];         // Query at i2

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

            /*
            List<int> list1 = new List<int>(){ 1, 2, 3 };
            List<int> list2 = new List<int>(){ 4, 5, 6 };

            List<int> result = list1 + list2;
            */


        }
    }
}
