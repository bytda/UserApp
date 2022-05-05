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

namespace UsersApp
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
        Data data = new Data();
        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {
            data.Log = BoxLogin.Text.ToLower().Trim();
            data.Pas = BoxPassword.Text.Trim();
            if (data.Log != "" & data.Pas != "")
            {
                MessageBox.Show($"Вы зарегистрировались \nВаш логин:{data.Log} Ваш пароль:{data.Pas}");
            }
            else MessageBox.Show("Введите данные");

        }
         class Data
        {
            private string log = "Undefined";
            public string Log
            {
                set { log = value; }
                get { return log; }

            }
            private string pas = "Undefined";
            public string Pas
            {
                set { pas = value; }
                get { return pas; }

            }
        }
            private void ButtonAuth_Click(object sender, RoutedEventArgs e)
            {
                Window1 window1 = new Window1();
            window1.UserLog = data.Log;
            window1.UserPas = data.Pas;

            window1.Show();
             this.Close();
            ;


            }
        
        }
    }

