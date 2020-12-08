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

namespace ServiceASU1.Forms
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void btn_records_Click(object sender, RoutedEventArgs e)
        {
            Forms.Records records = new Records();
            records.Show();
            Close();
        }

        private void btn_сlients_Click(object sender, RoutedEventArgs e)
        {
            Forms.Clients clients = new Clients();
            clients.Show();
            Close();
        }

        private void btn_services_Click(object sender, RoutedEventArgs e)
        {
            Services services = new Services();
            services.Show();
            Close();
        }
    }
}
