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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window_Client.xaml
    /// </summary>
    public partial class Window_Client : Window
    {
        public Window_Client()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void dataGrid_Initialized(object sender, EventArgs e)
        {
            demo_examenEntities demo_ExamenEntities = new demo_examenEntities();
            List<Order> products = demo_ExamenEntities.Order.ToList();
            dataGrid.ItemsSource = products;
        }
    }
}
