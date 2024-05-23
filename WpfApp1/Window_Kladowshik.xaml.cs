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
    /// Логика взаимодействия для Window_Kladowshik.xaml
    /// </summary>
    public partial class Window_Kladowshik : Window
    {
        public Window_Kladowshik()
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
            List<Rulon> products = demo_ExamenEntities.Rulon.ToList();
            List<string> tkani = new List<string>();
            foreach (var item in products)
            {
                tkani.Add(item.sostav);
            }
            dataGrid.ItemsSource = tkani;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            demo_examenEntities demo_ExamenEntities = new demo_examenEntities();
            demo_ExamenEntities.Product.Add(new Product()); 
        }
    }
}
