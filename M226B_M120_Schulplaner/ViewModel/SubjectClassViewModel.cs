using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using M226B_M120_Schulplaner.Model;
using System.IO;

namespace M226B_M120_Schulplaner.ViewModel
{
    class SubjectClassViewModel
    {
        public List<SubjectClass> _SubjectClassList = new List<SubjectClass>();

        public void addToList(SubjectClass subjectClass)
        {
            _SubjectClassList.Add(subjectClass);
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            // File.WriteAllText(projectDirectory + "\"JSON\"savefile.json", json);
        }

        public List<SubjectClass> getSubjectClassList()
        {
            return _SubjectClassList;
        }
        public void setSubjectClassList(List<SubjectClass> value)
        {
            _SubjectClassList = value;
        }
    }
}
