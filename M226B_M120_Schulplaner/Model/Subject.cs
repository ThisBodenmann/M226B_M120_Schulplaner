using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226B_M120_Schulplaner.Model
{
    internal class Subject
    {
        public class SubjectClass
        {
            string subject;
            string theme;
            DateTime date;
            string grade;
            public string Subject
            {
                get { return subject; }
                set { subject = value; }
            }
            public string Theme
            {
                get { return theme; }
                set { theme = value; }
            }
            public DateTime Date
            {
                get { return date; }
                set { date = value; }
            }
            public string Grade
            {
                get { return grade; }
                set
                {
                    if (int.TryParse(value, out int n))
                    {
                        grade = value;
                    }
                    else if (value.Contains(",") || value.Contains("."))
                    {
                        grade = value;
                    }
                    else
                    {
                        MessageBox.Show("Bitte geben Sie einen gültigen Notenwert an!");
                    }
                }
            }
        }
    }
}
