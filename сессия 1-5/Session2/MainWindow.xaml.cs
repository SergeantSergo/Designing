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

namespace Session2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OKNO.Navigate(new straniza1());

        }

        private void Abonent_Butt_Click(object sender, RoutedEventArgs e)
        {
            OKNO.Navigate(new straniza1());
            Label_to_Label.Content = "Абоненты ТНС";
        }

        private void Oborudowania_Click(object sender, RoutedEventArgs e)
        {
            OKNO.Navigate(new straniza2());
            Label_to_Label.Content = "Контроль состояния";
        }

        private void Billing_Click(object sender, RoutedEventArgs e)
        {
            OKNO.Navigate(new straniza4());
            Label_to_Label.Content = "Биллинг";
        }

        private void PROF_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("prrr");
        }

        private void CRM_butt_Click(object sender, RoutedEventArgs e)
        {
            OKNO.Navigate(new straniz3_CRM_());
            Label_to_Label.Content = "CRM";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OKNO.Navigate(new sos());
            Label_to_Label.Content = "Поддержка пользователей";
        }
    }
}
