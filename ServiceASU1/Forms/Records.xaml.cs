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
    /// Логика взаимодействия для Records.xaml
    /// </summary>
    public partial class Records : Window
    {
        public Records()
        {
            InitializeComponent();

            try
            {
                DB.Entities ef = new DB.Entities();
                dt_records.ItemsSource = ef.Records.ToList();
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
    }
}
