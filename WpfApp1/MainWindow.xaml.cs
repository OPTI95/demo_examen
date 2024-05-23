using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Window_Manager window = new Window_Manager();
            window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            demo_examenEntities demo_ExamenEntities = new demo_examenEntities();

            var User = demo_ExamenEntities.User.FirstOrDefault(u => u.login == loginBox.Text && u.password == passwordBox.Password);
            if (User == null)
            {
                MessageBox.Show("Нет такого пользователя", caption: "ошибка", button: MessageBoxButton.OK, icon: MessageBoxImage.Error);
            }
            else if (User.password != passwordBox.Password)
            {
                MessageBox.Show("Нет такого пользователя", caption: "ошибка", button: MessageBoxButton.OK, icon: MessageBoxImage.Error);

            }
            else
            {
                if (User.role_id == 1)
                {
                    Window_Client window_Client = new Window_Client();
                    window_Client.Show();
                    this.Close();
                }
                else if (User.role_id == 2)
                {
                    Window_Manager window_Manager = new Window_Manager();
                    window_Manager.Show();
                    this.Close();
                }
                else if (User.role_id == 3)
                {
                    Window_Kladowshik window_Kladowshik = new Window_Kladowshik();
                    window_Kladowshik.Show();
                    this.Close();

                    this.Close();
                }
                else if (User.role_id == 4)
                {
                    Window_Director window_Director = new Window_Director();
                    window_Director.Show();
                    this.Close();
                }
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window_Reg window_Reg = new Window_Reg();
            window_Reg.Show();
            this.Close();
        }
    }
}
