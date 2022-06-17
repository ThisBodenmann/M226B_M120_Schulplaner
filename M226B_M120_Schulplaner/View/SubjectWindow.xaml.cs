using M226B_M120_Schulplaner.Model;
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
        ViewModel.SubjectClassViewModel subjectClass = new ViewModel.SubjectClassViewModel();

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

        private void SubjectAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (GradeTextBox.Text.Contains('.'))
                {
                    MessageBox.Show("Geben Sie einen gültigen Wert ein");
                } else
                {
                    if (Convert.ToDouble(GradeTextBox.Text) >= 1 && Convert.ToDouble(GradeTextBox.Text) <= 6)
                    {
                        SubjectClass subject = new SubjectClass();
                        subject.Subject = SubjectComboBox.Text;
                        subject.Theme = ThemeTextBox.Text;
                        subject.Date = Convert.ToDateTime(DateTextBox.Text);
                        subject.Grade = GradeTextBox.Text;
                        subjectClass.addToList(subject);
                        this.SubjectDataGrid.ItemsSource = null;
                        this.SubjectDataGrid.ItemsSource = subjectClass.getSubjectClassList();
                    }
                    else MessageBox.Show("Die Note kann nur zwischen 1 und 6 sein.");
                }
            }
            catch (Exception ex)
            {
                
            }

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
