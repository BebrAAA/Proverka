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

namespace OOO_Beautiful.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserProductPage.xaml
    /// </summary>
    public partial class UserProductPage : Page
    {
        public UserProductPage()
        {
            InitializeComponent();

            AddDate.BD.Connect = new TradeEntities1();
            var product = AddDate.BD.Connect.Product.ToList();
            LVProductUser.ItemsSource = product;
        }

        private void LVProductUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TBSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            LVProductUser.ItemsSource = AddDate.BD.Connect.Product.Where(x => x.ProductName.StartsWith(TBSearch.Text)).ToList();
        }
    }
}
