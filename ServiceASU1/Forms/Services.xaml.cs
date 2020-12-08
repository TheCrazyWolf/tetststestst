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
    /// Логика взаимодействия для Services.xaml
    /// </summary>
    public partial class Services : Window
    {
        public Services()
        {
            InitializeComponent();

            Controller.Engine engine = new Controller.Engine();
            lb_services.ItemsSource = engine.list_viewer;
        }


        /// <summary>
        /// кнопка назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            var bt = e.OriginalSource as Button;
            var tp = bt.DataContext as Controller.Viewer;

            Forms.AddService addService = new AddService(tp);
            addService.Show();
            Close();

        }

        /// <summary>
        /// кнопка удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите удалить данный элемент", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    var bt = e.OriginalSource as Button;
                    var tp = bt.DataContext as Controller.Viewer;
                    DB.Entities ef = new DB.Entities();
                    var item = ef.Services.SingleOrDefault(x => x.idService == tp.idService);
                    ef.Services.Remove(item);
                    ef.SaveChanges();
                    lb_services.ItemsSource = "";
                    Controller.Engine engine = new Controller.Engine();
                    lb_services.ItemsSource = engine.list_viewer;
                    MessageBox.Show("Объект успешно удален", "ОК", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Удаление отменено");
            }

        }

        private void sort_Title_A_Click(object sender, RoutedEventArgs e)
        {
            Controller.Engine engine = new Controller.Engine();
            var s = engine.list_viewer.OrderBy(x => x.Title);
            lb_services.ItemsSource = s;

        }

        private void sort_Title_Z_Click(object sender, RoutedEventArgs e)
        {
            Controller.Engine engine = new Controller.Engine();
            var s = engine.list_viewer.OrderByDescending(x => x.Title);
            lb_services.ItemsSource = s;
        }

        private void sort_Cost_Click(object sender, RoutedEventArgs e)
        {
            Controller.Engine engine = new Controller.Engine();
            var s = engine.list_viewer.OrderBy(x => x.CostSort);
            lb_services.ItemsSource = s;
        }

        private void sort_Cost_deg_Click(object sender, RoutedEventArgs e)
        {
            Controller.Engine engine = new Controller.Engine();
            var s = engine.list_viewer.OrderByDescending(x => x.CostSort);
            lb_services.ItemsSource = s;
        }

        private void sort_add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
