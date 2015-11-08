using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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


        public static int unique_number = 0;

        public DataStorage()
        {
            LoadNumber();
            //Console.WriteLine("unique number: " + unique_number);
            //IncrementNumber();
            //Console.WriteLine("unique number: " + unique_number);

            this.sessionID = 1;
            measurementsList = new List<Measurement>();
            dir = MakeResourceMap();
            Console.WriteLine(dir);
        }

        public static void IncrementNumber()
        {
            unique_number++;
            var file = File.Open(AppDomain.CurrentDomain.BaseDirectory + "unique_number.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(unique_number);
            writer.Flush();
            writer.Close();
        }

        public static void LoadNumber()
        {
            if (File.Exists(@"C:\Users\Malek\Documents\GitHub\ProjectgroepA1\Server\bin\Debug"))
            {
                var file = File.Open(AppDomain.CurrentDomain.BaseDirectory + "unique_number.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file);
                unique_number = int.Parse(reader.ReadLine());
                reader.Close();
            }
            else
            {
                Console.WriteLine("File bestaat niet");
            }
        }

        public static int GetUniqueNumber()
        {
            LoadNumber();
            IncrementNumber();
            return unique_number;
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
            for (int i = 0; i < number + 1; i++)
            {
                mapPath += split[i] + @"\";
            }

            //make the path to the resource map
            mapPath = Path.Combine(mapPath, mapName);

            if (!Directory.Exists(mapPath))
            {
                Directory.CreateDirectory(mapPath);
            }

            return mapPath + "\\";
        }

        public void AddMeasurement(Measurement measurement)
        {
            //Adds a serializable measurement to the List
            measurementsList.Add(measurement);
        }

        public string GetDir()
        {
            return dir;
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

        public List<Measurement> LoadFile(string filename)
        {
            string name = filename + ".mes";
            string path = Path.Combine(dir, name);
            Console.WriteLine(path);
            path.Replace("/", "//");
            List<Measurement> measurements = new List<Measurement>();
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                measurements = ((List<Measurement>)binaryFormatter.Deserialize(stream));
                stream.Close();
            }
            return measurements;
        }




    }
}