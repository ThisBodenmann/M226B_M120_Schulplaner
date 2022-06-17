using M226B_M120_Schulplaner.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
        ViewModel.HomeWorkClassViewModel homeWorkClass = new ViewModel.HomeWorkClassViewModel();
        public HomeworkWindow()
        {
            InitializeComponent();
            ViewModel.HomeWorkClassViewModel.loadFromFile();
            this.HomeWorkDataGrid.ItemsSource = null;
            this.HomeWorkDataGrid.ItemsSource = homeWorkClass.getHomeWorkClassList();
        }
        void changeWindowSubjects(object sender, RoutedEventArgs e)
        {
            SubjectWindow subjectWindow = new SubjectWindow();
            subjectWindow.Show();
            this.Close();
        }
        
        private void HomeWorkAdd_Click(object sender, RoutedEventArgs e)
        {
            HomeWorkClass work = new HomeWorkClass();
            work.Key = homeWorkClass.getKey();
            work.Subject = HomeWorkComboBox.Text;
            work.Task = HomeWorkTaskBox.Text;
            work.Date = Convert.ToDateTime(HomeWorkDateBox.Text);
            work.Done = false;
            homeWorkClass.addToList(work);
            this.HomeWorkDataGrid.ItemsSource = null;
            this.HomeWorkDataGrid.ItemsSource = homeWorkClass.getHomeWorkClassList();
        }
    }
}
