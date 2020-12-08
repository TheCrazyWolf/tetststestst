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

namespace ServiceASU1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, RoutedEventArgs e)
        {
            Forms.Menu menu = new Forms.Menu();
            menu.Show();
            Close();
        }

        private void btn_admin_Click(object sender, RoutedEventArgs e)
        {

            if (tb_pass.Text == "0000")
            {
                App.TypeUser = "admin";
                Forms.Menu menu = new Forms.Menu();
                menu.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }
    }
}
