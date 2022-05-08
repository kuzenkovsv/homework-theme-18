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
    public class EditClientViewModel
    {
        DatabaseAccesses dbA = new DatabaseAccesses();
        MainWindow t;

        /// <summary>
        /// Редактирование клиента
        /// </summary>
        private RelayCommand edit1Client;
        public RelayCommand Edit1Client
        {
            get
            {
                return edit1Client ??
                  (edit1Client = new RelayCommand(obj =>
                  {
                      var edClient = obj as EditCLient;

                      try
                      {
                          if (edClient.ClientName.Text != null & edClient.Email.Text != null)
                          {

                              int ID = Convert.ToInt32(edClient.ID.Text);
                              t.clientsTable.ItemsSource = dbA.EditClientMethod(ID,
                                 edClient.ClientName.Text,
                                 edClient.Tel.Text,
                                 edClient.Email.Text)
                             .Clients.Local.ToBindingList<Clients>()
                             .OrderBy(e => e.Id);

                              MessageBoxResult result = MessageBox.Show($"Данные клиента отредактированы",
                          "Успешное изменение",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);

                              switch (result)
                              {
                                  case MessageBoxResult.OK:
                                      edClient.Edit.Close();
                                      break;
                              }
                          }
                      }
                      catch (Exception e707)
                      {
                          MessageBox.Show($"{e707.Message}", "Ошибка-e707!", MessageBoxButton.OK, MessageBoxImage.Information);
                      }

                  }));
            }
        }

        public EditClientViewModel(MainWindow win)
        {
            t = win;
        }
    }
}
