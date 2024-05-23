using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Window_Reg.xaml
    /// </summary>
    public partial class Window_Reg : Window
    {
        public Window_Reg()
        {
            InitializeComponent();
        }

        async private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length >= 6 && loginBox.Text.Length >= 6)
            {
                demo_examenEntities demo_ExamenEntities = new demo_examenEntities();
                User user = new User();
                user.role_id = 1;
                user.password = passwordBox.Password;
                user.login = loginBox.Text;
                demo_ExamenEntities.User.Add(user);
                await demo_ExamenEntities.SaveChangesAsync();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }
    }
}
