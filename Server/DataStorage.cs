using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetLib;

namespace Server
{
    class DataStorage
    {
        private int sessionID;
        private List<Measurement> measurements;


        public DataStorage()
        {
            this.sessionID = 1;
            measurements = new List<Measurement>();
        }

        public void AddMeasurement(Measurement measurement)
        {
            //Adds a serializable measurement to the List
            measurements.Add(measurement);
        }

        public void SaveFile()
        {

            string dir = "C:\\SaveLog\\";
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