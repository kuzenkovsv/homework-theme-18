using homework_theme_18.ViewModels;
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
using System.Windows.Shapes;

namespace homework_theme_18.Views
{
    /// <summary>
    /// Логика взаимодействия для EditCLient.xaml
    /// </summary>
    public partial class EditCLient : Window
    {
        public EditCLient(EditClientViewModel editClientViewModel)
        {
            DataContext = editClientViewModel;
            InitializeComponent();
        }
    }
}
