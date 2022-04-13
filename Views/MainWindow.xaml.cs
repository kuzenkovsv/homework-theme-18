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
        MSSQLLocalProductDBEntities context;

        public MainWindow()
        {
            InitializeComponent();
            context = new MSSQLLocalProductDBEntities();
            DataContext = new MainViewModel();

            try
            {
                context.Clients.Load();
                clientsTable.ItemsSource = context.Clients.Local.ToBindingList<Clients>();

                context.Product.Load();
                product.ItemsSource = context.Product.Local.ToBindingList<Product>();

                context.Orders.Load();
                order.ItemsSource = context.Orders.Local.ToBindingList<Orders>();
                //order.ItemsSource = context.Orders.Local.ToBindingList<Orders>().Where(a => a.Id > 5);
                //order.ItemsSource = context.Orders.Local.ToBindingList<Orders>().Where(a => a.ClientEmail == "Email_4");



            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "Ошибка-e!", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //OrderHistoryWindow oh = new OrderHistoryWindow();

            OrderHistoryViewModel orderHistoryViewModel = new OrderHistoryViewModel();
            OrderHistoryWindow oh = new OrderHistoryWindow(orderHistoryViewModel);
            var data = clientsTable.SelectedItem as Clients;
            oh.Title = $"История заказов клиента {data.LFMName}";
            //context = new MSSQLLocalProductDBEntities();
            //context.Orders.Load();
            //using (MSSQLLocalProductDBEntities db = new MSSQLLocalProductDBEntities())
            //{
                List<Orders> history = new List<Orders>();
                var orders = context.Orders;
                foreach (var item in context.Orders)
                {
                if (item.ClientEmail == data.Email)
                    //if (data.Email.Equals(item.ClientEmail))
                    //if (item.Id == 3)

                {
                    history.Add(item);
                    }
                }

            oh.history.ItemsSource = history;
            oh.ShowDialog();

            //}


            ////oh.history.ItemsSource = context.Orders.Local.ToBindingList<Orders>().Where(a => a.ClientEmail == $"{data.Email}");
            //oh.history.ItemsSource = context.Orders.Local.ToBindingList<Orders>().Where(a =>  a.ClientEmail.Contains(data.Email));


            //oh.ShowDialog();

        }

    }
}
