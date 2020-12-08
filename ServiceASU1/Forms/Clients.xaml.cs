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
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        public Clients()
        {
            InitializeComponent();

            try
            {
                DB.Entities ef = new DB.Entities();
                dt_clients.ItemsSource = ef.Clients.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Close();
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            var tp = dt_clients.SelectedItem;
            DB.Entities ef = new DB.Entities();
            MessageBox.Show(Convert.ToString(tp));
        }
    }
}
