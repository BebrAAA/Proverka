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

namespace OOO_Beautiful
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AddDate.MainFrame.frame = FrameMain;
            AddDate.BD.Connect = new TradeEntities1();
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            AddDate.MainFrame.frame.Navigate(new Pages.UserProductPage());
        }

        private void BtnInput_Click(object sender, RoutedEventArgs e)
        {
            if (AddDate.BD.Connect.User.Any(x => x.UserLogin == TBLogin.Text && x.UserPassword == TBPassword.Text && x.UserRole == 1))
            {
                AddDate.MainFrame.frame.Navigate(new Pages.UserProductPage());
            }
            else if (AddDate.BD.Connect.User.Any(x => x.UserLogin == TBLogin.Text && x.UserPassword == TBPassword.Text && x.UserRole == 2))
            {
                AddDate.MainFrame.frame.Navigate(new Pages.UserProductPage());
            }
            else if (AddDate.BD.Connect.User.Any(x => x.UserLogin == TBLogin.Text && x.UserPassword == TBPassword.Text && x.UserRole == 3))
            {
                AddDate.MainFrame.frame.Navigate(new Pages.UserProductPage());
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (AddDate.MainFrame.frame.CanGoBack)
            {
                AddDate.MainFrame.frame.GoBack();
            }
        }

        private void BtnInputNoUser_Click(object sender, RoutedEventArgs e)
        {
            AddDate.MainFrame.frame.Navigate(new Pages.UserProductPage());
        }
    }
}
