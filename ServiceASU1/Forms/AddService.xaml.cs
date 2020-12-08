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
    /// Логика взаимодействия для AddService.xaml
    /// </summary>
    public partial class AddService : Window
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ok");
        }

        private void btn_save_Copy_Click(object sender, RoutedEventArgs e)
        {
            Forms.Clients clients = new Clients();
            clients.Show();
            Close();
        }


        public AddService(Controller.Viewer tp) 
        {
            InitializeComponent();

            Title = "Редактирование";
            btn_save.Content = "Сохранить";
            try
            {
                stackpanel.DataContext = tp; 
            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}
