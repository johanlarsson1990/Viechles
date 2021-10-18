using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class RandomName
    {
        public string randomName(Random rnd)
        {
            List<string> nameList = new List<string>() { "Petrus", "Judas", "Taddeus", "Johannes", "Iskariot", "Matteus", "Tomas", "Jakob", "Andreas", "Filippos", "Simon", "Bartolomaios" };

            // Generate a random index less than the size of the array.  
            int index = rnd.Next(nameList.Count);

            return nameList[index];
        }
    }
}
