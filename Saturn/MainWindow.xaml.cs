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

namespace Saturn
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public struct Person
    {
        public string Marka;
        public string Marka1;
        public DateTime? dat;
        public DateTime? dat1;
        public char tip;
        public bool oldcar;
    }
    public partial class MainWindow : Window
    {
        Person[] persons;
        int i = 0;
        int count;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                try
                {
                    count = int.Parse(Count.Text);
                    persons = new Person[count];
                    AddPerson();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                AddPerson();
            }
            if (i == count)
            {
                Add.IsEnabled = false;
            }
        }
        public void AddPerson()
        {
            if (i < count)
            {
                Window1 window = new Window1();
                if (window.ShowDialog() == true)
                {
                    Person p = new Person();
                    p.Marka = window.getMarka();
                    p.Marka1 = window.getMarka1();
                    p.dat = window.getDat();
                    p.dat1 = window.getDat1();
                    p.tip = window.getTipe();
                    p.oldcar = window.getEkat();
                    persons[i] = p;
                    Cars.Items.Add(p.Marka);
                }
                i++;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Add.IsEnabled = false;
        }

        private void Count_TextChanged(object sender, TextChangedEventArgs e)
        {
            Add.IsEnabled = true;
        }

        private void Persons_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string f = Cars.SelectedItems[0].ToString();
            Person p;
            for (int i = 0; i < count; i++)
            {
                if (persons[i].Marka.Equals(f))
                {
                    p = persons[i];
                    Window1 w = new Window1(p);
                    w.Show();
                    break;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
