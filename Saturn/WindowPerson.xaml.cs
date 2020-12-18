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

namespace Saturn
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(Person p)
        {
            InitializeComponent();
            Mark.Text = p.Marka;
            Mark1.Text = p.Marka1;
            DateStart.SelectedDate = p.dat;
            DateReg.SelectedDate = p.dat1;
            if (p.tip == 'S') Sedan.IsChecked = true;
            else Gibrid.IsChecked = true;
            if (p.oldcar == true) BIFU.IsChecked = true;
        }
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        public string getMarka()
        {
            return Mark.Text;
        }
        public string getMarka1()
        {
            return Mark1.Text;
        }

        public DateTime? getDat()
        {
            return DateStart.SelectedDate;
        }
        public DateTime? getDat1()
        {
            return DateReg.SelectedDate;
        }
        public char getTipe()
        {
            if (Sedan.IsChecked == true) return 'S';
            return 'G';
        }

        public bool getEkat()
        {
            if (BIFU.IsChecked == true) return true;
            return false;
        }
    }
}
