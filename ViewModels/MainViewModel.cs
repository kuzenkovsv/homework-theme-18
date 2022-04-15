using homework_theme_18.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace homework_theme_18.ViewModels
{
    public class MainViewModel
    {
        BeanMagas context;


        /// <summary>
        /// История заказов
        /// </summary>
        private RelayCommand orderHistory;
        public RelayCommand OrderHistory
        {
            get
            {
                return orderHistory ??
                  (orderHistory = new RelayCommand(obj =>
                  {
                      OrderHistoryViewModel orderHistoryViewModel = new OrderHistoryViewModel();
                      OrderHistoryWindow oh = new OrderHistoryWindow(orderHistoryViewModel);

                      if (obj is Clients data)
                      {
                          oh.Title = $"История заказов клиента {data.LFMName}";


                          try
                          {
                              context = new BeanMagas();
                              context.Orders.Load();
                              oh.history.ItemsSource = context.Orders.Local.ToBindingList<Orders>().Where(a => a.ClientEmail == $"{data.Email}");
                              //oh.history.ItemsSource = context.Orders.Local.ToBindingList<Orders>().Where(a => a.ClientEmail.Contains(data.Email));
                          }
                          catch (Exception e4)
                          {
                              MessageBox.Show($"{e4.Message}", "Ошибка-e4!", MessageBoxButton.OK, MessageBoxImage.Information);
                          }

                          //oh.history.DataContext = sql1dt.DefaultView;

                          oh.ShowDialog();

                      }



                  }
                  ));
            }
        }


        /// <summary>
        /// Добавление клиента
        /// </summary>
        private RelayCommand addClient;
        public RelayCommand AddClient
        {
            get
            {
                return addClient ??
                  (addClient = new RelayCommand(obj =>
                  {
                      var win = obj as MainWindow;
                      AddClientViewModel addClientViewModel = new AddClientViewModel(win);
                      AddClientWindow addСlient = new AddClientWindow(addClientViewModel);
                      addСlient.ShowDialog();

                  }));
            }
        }

        /// <summary>
        /// Удаление клиента
        /// </summary>
        private RelayCommand deleteClient;
        public RelayCommand DeleteClient
        {
            get
            {
                return deleteClient ??
                  (deleteClient = new RelayCommand(obj =>
                  {

                      try
                      {
                          MainWindow win = obj as MainWindow;
                          context = new BeanMagas();
                          Clients cl = win.clientsTable.SelectedItem as Clients;
                          int id = cl.Id;

                          Clients client = context.Clients.Find(id);
                          context.Clients.Remove(client);

                          context.SaveChanges();
                          context.Clients.Load();
                          win.clientsTable.ItemsSource = context.Clients.Local.ToBindingList<Clients>();

                      }
                      catch (Exception e3)
                      {
                          MessageBox.Show($"{e3.Message}", "Ошибка-e3!", MessageBoxButton.OK, MessageBoxImage.Information);
                      }

                  }
                  ));
            }
        }

        /// <summary>
        /// Изменение клиента
        /// </summary>
        private RelayCommand editClient;
        public RelayCommand EditClient
        {
            get
            {
                return editClient ??
                  (editClient = new RelayCommand(obj =>
                  {
                      var win = obj as MainWindow;
                      Clients data = win.clientsTable.SelectedItem as Clients;

                      EditClientViewModel editClientViewModel = new EditClientViewModel(win);
                      EditCLient editСl = new EditCLient(editClientViewModel);

                      editСl.Title = $"Изменение клиента {data.LFMName}";
                      editСl.ID.Text = data.Id.ToString();
                      editСl.ClientName.Text = data.LFMName.ToString();
                      editСl.Tel.Text = data.Telephone.ToString();
                      editСl.Email.Text = data.Email.ToString();
                      editСl.ShowDialog();

                  }));
            }
        }


        /// <summary>
        /// Добавление заказа
        /// </summary>
        private RelayCommand addOrderCommand;
        public RelayCommand AddOrderCommand
        {
            get
            {
                return addOrderCommand ??
                  (addOrderCommand = new RelayCommand(obj =>
                  {
                      var win = obj as MainWindow;
                      NewOrderViewModel newOrderView = new NewOrderViewModel(win);
                      NewOrderWindow newOrder = new NewOrderWindow(newOrderView);

                      if (win.clientsTable.SelectedItem is Clients data)
                      {
                          newOrder.Title = $"Новый заказ клиента {data.LFMName}";
                          newOrder.ClientEmail.Text = $"{data.Email}";
                          context = new BeanMagas();
                          context.Product.Load();


                          try
                          {
                              newOrder.productName.ItemsSource = context.Product.Local.ToBindingList<Product>();

                              newOrder.ShowDialog();
                          }
                          catch (Exception e5)
                          {
                              MessageBox.Show($"{e5.Message}", "Ошибка-e5!", MessageBoxButton.OK, MessageBoxImage.Information);
                          }

                      }

                  }));
            }
        }


        public MainViewModel()
        {

        }
    }
}
