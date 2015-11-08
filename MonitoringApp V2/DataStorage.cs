using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NetLib;

namespace Server
{
    class DataStorage
    {
        private int sessionID;
        public List<Measurement> measurementsList { get; }
        private string dir;

        public DataStorage()
        {
            this.sessionID = 1;
            measurementsList = new List<Measurement>();
            dir = MakeResourceMap();
            Console.WriteLine(dir);
        }

        /*
            return the path of the resource map;
        */
        public string MakeResourceMap()
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

            return mapPath + "\\";
        }

        public string GetDir()
        {
            return dir;
        }

        public void AddMeasurement(Measurement measurement)
        {
            //Adds a serializable measurement to the List
            measurementsList.Add(measurement);
        }

        public void SaveFile()
        {
            string filePath = sessionID.ToString("D6") + ".mes";
            string path = Path.Combine(dir + filePath);
            while (File.Exists(path))
            {
                sessionID++;
                dir = sessionID.ToString("D6") + ".mes";
            }

            using (Stream stream = File.Open(path, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, measurementsList);
                stream.Close();
            }
            Console.WriteLine(filePath);
        }

        public void LoadFile(string filename)
        {
            string path = Path.Combine(dir,filename);

            if (File.Exists(path))
            {
                Console.WriteLine("bestand bestaat");
            }
            else
            {
                Console.WriteLine("bestaand niet gevonden");
            }
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                List<Measurement> measurements = ((List < Measurement >) binaryFormatter.Deserialize(stream));
            }
            Console.WriteLine("De file is geupload!");
        }

        


    }
}