using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using NetLib;

namespace Server
{
    class DataStorage
    {
        private int sessionID;
        private List<Measurement> measurements;
<<<<<<< HEAD
        private string dir;
=======

>>>>>>> Client-Jeroen-

        public DataStorage()
        {
            this.sessionID = 1;
            measurements = new List<Measurement>();
            dir = MakeResourceMap();
            Console.WriteLine(dir);
        }

        /*
            return the path of the resource map;
        */
        private string MakeResourceMap()
        {
            string mapPath = Directory.GetCurrentDirectory();
            string mapName = "ResourceMapMeasurements";
            String[] split = mapPath.Split(Path.DirectorySeparatorChar);

            //search for the server map, exsists in every repository
            int number = 0;
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].ToLower() == "server")
                {
                    number = i;
                    break;
                }
            }

            //make the path to the server map
            mapPath = "";
            for (int i = 0; i < number+1; i++)
            {
                mapPath += split[i]+@"\";
            }

            //make the path to the resource map
            mapPath = Path.Combine(mapPath,mapName);

            if (!Directory.Exists(mapPath))
            {
                Directory.CreateDirectory(mapPath);
            }

            return mapPath;
        }

        public void AddMeasurement(Measurement measurement)
        {
            //Adds a serializable measurement to the List
            measurements.Add(measurement);
        }

        public void SaveFile()
        {
            string filePath = sessionID.ToString("D6") + ".mes";
            while (File.Exists(dir + filePath))
            {
                sessionID++;
                filePath = sessionID.ToString("D6") + ".mes";
            }

            using (Stream stream = File.Open(filePath, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, measurements);
            }
        }

    }
}