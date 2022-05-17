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

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);

            ListBoxItem david = new ListBoxItem();
            david.Content = "James";
            peopleListBox.Items.Add(david);

            peopleListBox.SelectedItem = james;
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            string s = "";

            foreach (var item in MainGrid.Children)
            {
                if(item is TextBox)
                {
                    s = s +((TextBox)item).Text;
                    s = s + '\n';
                }
            }

            if (txtName.Text.Length > 2)
                MessageBox.Show("Здрасти " + s + "!!! Това е твоята първа програма на Visul Syudtio 2012!");
            else
                MessageBox.Show("Въведете валидно име.");
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtName_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("This is Windows Presentation Foundation!");
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();

            textBlosck1.Text = DateTime.Now.ToString();
        }

        private void txtName_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void calculateFactorial(object sender, RoutedEventArgs e)
        {
            int factorial, result;
            factorial = int.Parse(txtN.Text);
            result = Factorial(factorial);
            MessageBox.Show(result.ToString());
           
        }

        private int Factorial (int num)
        {
            if(num == 1) 
                return 1;
            else
                return num * Factorial(num - 1);
        }

        private void calculatePowNY(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int y = int.Parse(txtY.Text);

            int result = (int)Math.Pow(n, y);
            MessageBox.Show(result.ToString());
        }

        private void peopelListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void onGreeting(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMsg);
        }
    }
}
