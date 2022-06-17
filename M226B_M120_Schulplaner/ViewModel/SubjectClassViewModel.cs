using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using M226B_M120_Schulplaner.Model;
using System.IO;
using Newtonsoft.Json;

namespace M226B_M120_Schulplaner.ViewModel
{
    class SubjectClassViewModel
    {
        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        static string realPath = projectDirectory + "\\JSON\\subjectHomeWork.json";
        public static List<SubjectClass> _SubjectClassList = new List<SubjectClass>();

        public void addToList(SubjectClass subjectClass)
        {
            _SubjectClassList.Add(subjectClass);
            var jsonString = JsonConvert.SerializeObject(_SubjectClassList);
            File.WriteAllText(realPath, jsonString);
        }

        public List<SubjectClass> getSubjectClassList()
        {
            return _SubjectClassList;
        }
        public static void loadFromFile()
        {
            if (File.Exists(realPath))
            {
                using (StreamReader r = new StreamReader(realPath))
                {
                    string json = r.ReadToEnd();
                    List<SubjectClass> items = JsonConvert.DeserializeObject<List<SubjectClass>>(json);
                    _SubjectClassList = items;
                }
            }
            else
            {
                File.Create(realPath);
            }
        }
        public void setSubjectClassList(List<SubjectClass> value)
        {
            _SubjectClassList = value;
        }
        public int getKey()
        {
            int key = 0;
            key++;
            return key;
        }
    }
}
