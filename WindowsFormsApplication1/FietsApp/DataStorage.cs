﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ClientApp
{
    class DataStorage
    {
        public List<string> data { get; }
        private string doctor;
        private string user;
        private string destination;

        public DataStorage(String doctor, String user)
        {
            data = new List<string>();
            this.doctor = doctor;
            this.user = user;
            destination = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/KepplerData.txt";
        }

        public void addData(String add)
        {
            data.Add(add);
        }

        public void writeData()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(destination);
            file.WriteLine(doctor);
            file.WriteLine(user);
            foreach (string line in data)
            {
                file.WriteLine(line);
            }
            file.Close();
        }

        public void readData()
        {
            data.Clear();
            string[] readText = File.ReadAllLines(destination);
            foreach (string line in readText)
            {
                data.Add(line);
            }
        }
    }
}
