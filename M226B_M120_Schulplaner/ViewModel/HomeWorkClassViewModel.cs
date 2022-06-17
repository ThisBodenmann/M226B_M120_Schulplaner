﻿using M226B_M120_Schulplaner.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226B_M120_Schulplaner.ViewModel
{
    class HomeWorkClassViewModel
    {
        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        static string realPath = projectDirectory + "\\JSON\\saveFileHomeWork.json";
        public List<HomeWorkClass> _HomeWorkList = new List<HomeWorkClass>();
        public void addToList(HomeWorkClass HomeWorkClass)
        {
            _HomeWorkList.Add(HomeWorkClass);

        }

        public List<HomeWorkClass> getHomeWorkClassList()
        {
            return _HomeWorkList;
        }
        public void setHomeWorkClassList(List<HomeWorkClass> value)
        {
            _HomeWorkList = value;
        }
        public static void loadFromFile()
        {
            if (File.Exists(realPath))
            {
                using (StreamReader r = new StreamReader(realPath))
                {
                    string json = r.ReadToEnd();
                    List<HomeWorkClass> items = JsonConvert.DeserializeObject<List<HomeWorkClass>>(json);
                }
            } else
            {
                File.Create(realPath);
            }
        }
    }
}
