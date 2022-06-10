using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using M226B_M120_Schulplaner.Model;

namespace M226B_M120_Schulplaner.ViewModel
{
    class SubjectClassViewModel
    {
        public List<SubjectClass> _SubjectClassList = new List<SubjectClass>();

        public void addToList(SubjectClass subjectClass)
        {
            _SubjectClassList.Add(subjectClass);
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
