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
    public class AddClientViewModel
    {
        DatabaseAccesses dbA=new DatabaseAccesses();
        MainWindow t;


        /// <summary>
        /// Добавление клиента
        /// </summary>
        private RelayCommand add1Client;
        public RelayCommand Add1Client
        {
            get
            {
                return add1Client ??
                  (add1Client = new RelayCommand(obj =>
                  {
                      var newClient = obj as AddClientWindow;

                      try
                      {
                          if (newClient.ClientName.Text != null & newClient.Email.Text != null)
                          {
                              t.clientsTable.ItemsSource = dbA.AddClientMethod(
                                  newClient.ClientName.Text, 
                                  newClient.Tel.Text, 
                                  newClient.Email.Text)
                              .Clients.Local.ToBindingList<Clients>()
                              .OrderBy(e => e.Id);

                              MessageBoxResult result = MessageBox.Show($"Клиент {newClient.ClientName.Text} добавлен",
                             "Успешное добавление",
                             MessageBoxButton.OK,
                             MessageBoxImage.Information);

                              switch (result)
                              {
                                  case MessageBoxResult.OK:
                                      newClient.NewClient.Close();
                                      break;
                              }
                          }
                      }
                      catch (Exception e7)
                      {
                          MessageBox.Show($"{e7.Message}", "Ошибка-e7!", MessageBoxButton.OK, MessageBoxImage.Information);
                      }

                  }));
            }
        }


        public AddClientViewModel(MainWindow win)
        {
            t = win;
        }
    }
}
