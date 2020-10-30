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

            /// CUSTOMLIST ///            
            CustomList<int> customList01 = new CustomList<int>() {1, 2, 3, 4, 5 };
            CustomList<int> customList02 = new CustomList<int>() {6, 7, 8, 9, 10 };
            CustomList<int> comboList = new CustomList<int>();

            customList01.Add(1);
            customList01.Remove(1);
            customList01.RemoveAt(0);
           // customList01.RemoveDuplicates(customList01);
            customList01.Sort();
            
            string str = customList01.ToString();
            int count = customList01.Count;
            int size = customList01.Size;

            comboList = customList01 + customList02;
            comboList = customList01 - customList02;
            comboList = comboList.Merge(customList01, customList02);
            comboList = customList01.Zip(customList01, customList02);
                        
        }
    }
}
