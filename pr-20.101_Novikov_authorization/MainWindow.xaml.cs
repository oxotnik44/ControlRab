using pr_20._101_Novikov_authorization.Models;
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

namespace pr_20._101_Novikov_authorization
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = txtBoxLogin.Text;
            string password = txtBoxPassword.Text;
            helper helper = new helper();
            controlEntities control = helper.GetContext();
            if (login == "")
            {
                if (password == "")
                {
                    MessageBox.Show("Введите логин и пароль.");
                }
                else
                {
                    MessageBox.Show("Введите логин.");
                }
            }
            else if (password == "")
            {
                MessageBox.Show("Введите пароль.");
            }
            else
            {
                string result = helper.FindUsers(login, password);
                MessageBox.Show(result);
            }
        }
    

    }
}
