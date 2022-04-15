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
using System.Data.Entity;
using homework_theme_18.ViewModels;

namespace homework_theme_18.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BeanMagas context;

        public MainWindow()
        {
            InitializeComponent();
            context = new BeanMagas();
            DataContext = new MainViewModel();

            try
            {
                context.Clients.Load();
                clientsTable.ItemsSource = context.Clients.Local.ToBindingList<Clients>();

                context.Product.Load();
                product.ItemsSource = context.Product.Local.ToBindingList<Product>();

                context.Orders.Load();
                order.ItemsSource = context.Orders.Local.ToBindingList<Orders>();

            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "Ошибка-e!", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

    }
}
