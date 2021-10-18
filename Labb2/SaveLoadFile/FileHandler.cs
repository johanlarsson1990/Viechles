using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleClasses;

namespace SaveLoadFile
{
    public class FileHandler
    { 
        public string newPath = new StreamWriter("text.txt").ToString();

        public bool SaveData(List<string> listOfRowsToSave)
        {
            File.WriteAllLines(newPath, listOfRowsToSave);

            return true;
        }

        public List<string> GetSavedData()
        {
            List<string> lines = File.ReadAllLines(newPath).ToList();

            return lines;

        }
    }
}
