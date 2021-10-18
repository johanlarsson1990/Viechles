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
        
        public string filePath = @"Text.txt";



        public bool SaveData(List<string> listOfRowsToSave)
        {
            var NewPath = new StreamWriter("Text.txt");
            foreach (var row in listOfRowsToSave)
            {
                NewPath.WriteLine(row);
            }

            NewPath.Close();

            return true;
        }

        public List<string> GetSavedData()
        {
            var filePath = @"Text.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            return lines;

        }
    }
}
