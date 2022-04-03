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
        //MSSQLLocalProductDBEntities context;

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
                      OrderHistoryWindow oh = new OrderHistoryWindow();
                      oh.ShowDialog();


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
                      AddClientViewModel addClientViewModel = new AddClientViewModel();
                      AddClientWindow addСlient = new AddClientWindow(addClientViewModel);
                      addСlient.ShowDialog();

                  }));
            }
        }

        public MainViewModel()
        {

        }
    }
}
