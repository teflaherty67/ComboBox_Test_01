using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace ComboBox_Test_01
{
    public partial class MyForm : Window
    {
        public ObservableCollection<Item> ItemList { get; set; }

        public MyForm()
        {
            InitializeComponent();

            ItemList = new ObservableCollection<Item>
        {
            new Item { Name = "Item 1" },
            new Item { Name = "Item 2" },
            new Item { Name = "Item 3" },
            // Add more items as needed
        };
            DataContext = this;
        }
    }
}





