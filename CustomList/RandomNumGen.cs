using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    class RandomNumGen
    {
        Random Random;

        public int GenerateRandomInt(int min, int max)
        {   // Generates a random number
            
            Random = new Random(Guid.NewGuid().GetHashCode());
            int hash = 0; 
            hash = Random.Next(min, max);
            return hash;

        }

        public string GenerateRandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            Random = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[Random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }


    }
}
