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

namespace UsersApp
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {   public string UserLog { get; set; }
        public string UserPas { get; set; }
        public Window1()
        {
            InitializeComponent();
        }
        
       
        private void ButtonAuth_Click(object sender, RoutedEventArgs e)
        {
            string login = BoxLogin.Text.ToLower().Trim();
            string password = BoxPassword.Text.Trim();
            if (login == UserLog & password == UserPas)
            {
                MessageBox.Show("Вы авторизованы");
            }
            else MessageBox.Show("Неверные данные");
        }
    }
}
