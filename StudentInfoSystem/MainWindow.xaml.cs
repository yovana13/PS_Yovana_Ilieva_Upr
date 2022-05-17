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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onClear(object sender, RoutedEventArgs e)
        {
            foreach (var item in personalData.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }

            foreach (var item in studentData.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        private void enableBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in personalData.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }

            foreach (var item in studentData.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
        }

        private void onDisable(object sender, RoutedEventArgs e)
        {

            foreach (var item in personalData.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }

            foreach (var item in studentData.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
        }

        private void onDisplayData(object sender, RoutedEventArgs e)
        {
            DataContext = Student.GetStudent();

        }

        public void copyDataForEmpty()
        {
            if (TestStudentsIfEmpty())
            {
                CopyTestStudents();
                CopyTestUsers();
            }
        }
        private bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> queryStudents = context.Students;
            int countStudents = queryStudents.Count();
            if (countStudents == 0)
            {
                return true;
            }
            return false;
        }

        private void CopyTestStudents()
        {
            StudentInfoContext context = new StudentInfoContext();
            foreach (Student st in StudentData.TestStudents)
            {
                context.Students.Add(st);
            }
            context.SaveChanges();
        }

        private void CopyTestUsers()
        {
            PS_31_Yovana_Ilieva_Upr2_working.UserContext context = new PS_31_Yovana_Ilieva_Upr2_working.UserContext();
            foreach (PS_31_Yovana_Ilieva_Upr2_working.User user in PS_31_Yovana_Ilieva_Upr2_working.UserData.TestUser)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();
        }
    }
}
