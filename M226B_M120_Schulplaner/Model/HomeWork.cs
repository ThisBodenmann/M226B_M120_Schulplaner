using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226B_M120_Schulplaner.Model
{
    public class HomeWorkClass
    {
        int key;
        string subject;
        string task;
        DateTime date;
        bool done;
        public int Key
        {
            set { key = value; }
            get { return key; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Task
        {
            get { return task; }
            set { task = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
    }
}
