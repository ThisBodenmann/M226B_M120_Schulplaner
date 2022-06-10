using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace M226B_M120_Schulplaner
{
    /// <summary>
    /// Interaktionslogik für SubjectWindow.xaml
    /// </summary>
    public partial class SubjectWindow : Window
    {
        ObservableCollection<SubjectClass> SubjectList = new ObservableCollection<SubjectClass>();
        public SubjectWindow()
        {
            InitializeComponent();
        }

        private void changeWindowHomework(object sender, RoutedEventArgs e)
        {
            HomeworkWindow homeworkWindow = new HomeworkWindow();
            homeworkWindow.Show();
            this.Close();
        }

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
                set { 
                    if (int.TryParse(value, out int n))
                    {
                        grade = value;
                    } else if (value.Contains(",") || value.Contains("."))
                    {
                        grade = value;
                    } else
                    {
                        MessageBox.Show("Bitte geben Sie einen gültigen Notenwert an!");
                    }
                }
            }
        }

        private void SubjectAdd_Click(object sender, RoutedEventArgs e)
        {
            SubjectClass work = new SubjectClass();
            work.Subject = SubjectComboBox.Text;
            work.Theme = ThemeTextBox.Text;
            work.Date = Convert.ToDateTime(DateTextBox.Text);
            work.Grade = GradeTextBox.Text;
            SubjectList.Add(work);
            this.SubjectDataGrid.ItemsSource = null;
            this.SubjectDataGrid.ItemsSource = SubjectList;
        }

        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
        private static readonly Regex _regex = new Regex("^[0-9,.]*$");
        private static bool IsTextAllowed(string text)
        {
            return _regex.IsMatch(text);
        }
    }
}
