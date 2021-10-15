﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveLoadFile;
using VehicleClasses;


namespace Parser
{
    
    public class FileParser
    {
        private FileHandler _fileHandler = new FileHandler();
        public List<string> DataRows { get; set; }

        public FileParser()
        {
            DataRows = _fileHandler.GetSavedData();
            GetVehiclesFromSavedData(DataRows);
        }

        public FileParser(List<IVehicle> list)
        {
            _fileHandler.SaveData(WriteToTextFile(list));
            

        }
        public List<string> WriteToTextFile(List<IVehicle> list)
        {
            List<string> lines = new List<string>();
            

            foreach (var vehicle in list)
            {
                lines.Add($"{vehicle.Type};{vehicle.Name};{vehicle.Speed}");
            }

            //File.WriteAllLines(path, lines)
            return lines;

        }

        public List<IVehicle> GetVehiclesFromSavedData(List<string> dataRows)
        {
            List<IVehicle> savedVehicles = new List<IVehicle>();

            foreach (var row in dataRows)
            {
                string[] splittedLines = row.Split(';');

                

                switch (splittedLines[0])
                {
                    case "Car":
                        savedVehicles.Add(new Car { Name = splittedLines[1], Speed = int.Parse(splittedLines[2]) });
                        break;
                    case "Boat":
                        savedVehicles.Add(new Boat { Name = splittedLines[1], Speed = int.Parse(splittedLines[2]) });
                        break;
                    default:
                        savedVehicles.Add(new Motorcycle { Name = splittedLines[1], Speed = int.Parse(splittedLines[2]) });
                        break;
                }
            }

            return savedVehicles;
        }
    }
}