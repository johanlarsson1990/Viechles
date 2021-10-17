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
        public string NewPath { get; set; } = @"C:\temp\Labb3\text.txt";

        public bool SaveData(List<string> listOfRowsToSave)
        {
            File.WriteAllLines(NewPath, listOfRowsToSave);

            return true;
        }

        public List<string> GetSavedData()
        {
            List<string> lines = File.ReadAllLines(NewPath).ToList();

            return lines;

        }
    }
}
