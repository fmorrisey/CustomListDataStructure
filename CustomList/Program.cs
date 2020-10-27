using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> newlist = new CustomList<int>();
            for (int i = 0; i < 8; i++)
            {
                customList.Add(i);
                
            }

            
        }
    }
}
