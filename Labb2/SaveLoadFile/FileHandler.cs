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
        string path = @"C:\temp\Labb3\text.txt";

        public bool SaveData(List<string> listOfRowsToSave)
        {
            File.WriteAllLines(path, listOfRowsToSave);

            return true;
        }

        public List<string> GetSavedData()
        {
            List<string> lines = File.ReadAllLines(path).ToList();

            return lines;

        }
    }
}
