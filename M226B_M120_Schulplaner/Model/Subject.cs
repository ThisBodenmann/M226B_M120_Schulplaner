using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace M226B_M120_Schulplaner.Model
{
    public class SubjectClass : INotifyPropertyChanged
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
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
