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
    public class NewOrderViewModel
    {
        MainWindow t;


        /// <summary>
        /// Добавление заказа
        /// </summary>
        private RelayCommand newOrderAdd;
        public RelayCommand NewOrderAdd
        {
            get
            {
                return newOrderAdd ??
                  (newOrderAdd = new RelayCommand(obj =>
                  {
                      var newOrd = obj as NewOrderWindow;

                      try
                      {
                          if (newOrd.productName != null)
                          {
                              using (MSSQLLocalProductDBEntities db = new MSSQLLocalProductDBEntities())
                              {
                                  Product row = newOrd.productName.SelectedItem as Product;
                                  Orders nOrd = new Orders
                                  {
                                      ClientEmail = newOrd.ClientEmail.Text,
                                      IdProduct = newOrd.productName.SelectedIndex + 1,
                                      ProductName = row.ProductName,
                                      Quantity = Convert.ToInt32(newOrd.Quantity.Text)
                                  };
                                  db.Orders.Add(nOrd);
                                  db.SaveChanges();
                                  db.Orders.Load();
                                  t.order.ItemsSource = db.Orders.Local.ToBindingList<Orders>().OrderBy(e => e.Id);
                              }

                              MessageBoxResult result = MessageBox.Show($"Заказ успешно добавлен",
                         "Успешно!",
                         MessageBoxButton.OKCancel,
                         MessageBoxImage.Information);

                              switch (result)
                              {
                                  case MessageBoxResult.OK:
                                      newOrd.NewOrder.Close();
                                      break;

                                  case MessageBoxResult.Cancel:
                                      break;
                              }
                          }
                      }
                      catch (Exception e6)
                      {
                          MessageBox.Show($"{e6.Message}", "Ошибка-e6!", MessageBoxButton.OK, MessageBoxImage.Information);
                      }

                  }));
            }
        }

        public NewOrderViewModel(MainWindow win)
        {
            t = win;
        }
    }
}
