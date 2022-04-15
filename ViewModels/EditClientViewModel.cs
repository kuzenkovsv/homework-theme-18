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

                              int ID = Convert.ToInt32(edClient.ID);

                              using (BeanMagas db = new BeanMagas())
                              {
                                  //foreach (var item in db.Clients)
                                  //{
                                  //    if (item.Id == ID)
                                  //    {
                                  //        item.LFMName = edClient.ClientName.Text;
                                  //        item.Telephone = edClient.Tel.Text;
                                  //        item.Email = edClient.Email.Text;
                                  //        db.SaveChanges();
                                  //    }
                                  //}

                                  Clients client = db.Clients.Find(ID);
                                  client.LFMName = edClient.ClientName.Text;
                                  client.Telephone = edClient.Tel.Text;
                                  client.Email = edClient.Email.Text;
                                  db.SaveChanges();

                                  db.Clients.Load();
                                  t.clientsTable.ItemsSource = db.Clients.Local.ToBindingList<Clients>().OrderBy(e => e.Id);
                              }


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
