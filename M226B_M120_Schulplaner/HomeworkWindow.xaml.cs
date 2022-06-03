using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
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
    /// Interaktionslogik für HomeworkWindow.xaml
    /// </summary>
    public partial class HomeworkWindow : Window
    {
        ObservableCollection<HomeWork> HomeWorkList = new ObservableCollection<HomeWork>();
        public HomeworkWindow()
        {
            InitializeComponent();
        }
        void changeWindowSubjects(object sender, RoutedEventArgs e)
        {
            SubjectWindow subjectWindow = new SubjectWindow();
            subjectWindow.Show();
            this.Close();
        }
        public class HomeWork
        {
            string subject;
            string task;
            DateTime date;
            bool done;
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

        private void HomeWorkAdd_Click(object sender, RoutedEventArgs e)
        {
            HomeWork work = new HomeWork();
            work.Subject = HomeWorkComboBox.Text;
            work.Task = HomeWorkTaskBox.Text;
            work.Date = Convert.ToDateTime(HomeWorkDateBox.Text);
            work.Done = false;
            HomeWorkList.Add(work);
            this.HomeWorkDataGrid.ItemsSource = null;
            this.HomeWorkDataGrid.ItemsSource = HomeWorkList;
        }
    }
}
