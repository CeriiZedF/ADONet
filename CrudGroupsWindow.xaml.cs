using ADONet.DAL.Entity;
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

namespace ADONet
{
    /// <summary>
    /// Логика взаимодействия для CrudGroupsWindow.xaml
    /// </summary>
    public partial class CrudGroupsWindow : Window
    {
        public DAL.Entity.ProductGroup ProductGroup1 = new DAL.Entity.ProductGroup();

        public CrudGroupsWindow(ProductGroup group)
        {
            InitializeComponent();
            this.ProductGroup1 = group;
            this.DataContext = this.ProductGroup1;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ProductGroup1 = null;
            Close();
        }
    }
}
