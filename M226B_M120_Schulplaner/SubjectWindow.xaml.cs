using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für SubjectWindow.xaml
    /// </summary>
    public partial class SubjectWindow : Window
    {
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
    }
}
