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
            /*
            CustomList<string> strList = new CustomList<string>();
            
            for (int i = 0; i < strList.Capacity; i++)
            {
                string str = "Hello";
                strList.Add(str);

            }
            
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
            */

            CustomList<int> removeList = new CustomList<int>();

            for (int i = 0; i < 8; i++)
            {
                removeList.Add(i);
            }

            removeList.Remove(1);

            





        }
    }
}
