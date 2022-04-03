using homework_theme_18.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace homework_theme_18.Views
{
    /// <summary>
    /// Логика взаимодействия для OrderHistoryWindow.xaml
    /// </summary>
    public partial class OrderHistoryWindow : Window
    {
        //MSSQLLocalProductDBEntities context;

        public OrderHistoryWindow()
        {
            InitializeComponent();
            //context = new MSSQLLocalProductDBEntities();
            //context.Orders.Load();

            //history.ItemsSource = context.Orders.Local.ToBindingList<Orders>().Where(e => e.Id > 5);
        }
    }
}
