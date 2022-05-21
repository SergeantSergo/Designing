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

namespace Session2
{
    /// <summary>
    /// Логика взаимодействия для straniz3_CRM_.xaml
    /// </summary>
    public partial class straniz3_CRM_ : Page
    {
        private User _currentUser = new User();
        public straniz3_CRM_()
        {
            InitializeComponent();
            
        }

        private void Save_butt_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentUser.FIO))
                errors.AppendLine("Укажите ФИО");
        }
    }
}
