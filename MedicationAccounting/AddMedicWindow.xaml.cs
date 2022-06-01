using Services;
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

namespace MedicationAccounting
{
    /// <summary>
    /// Логика взаимодействия для AddMedicWindow.xaml
    /// </summary>
    public partial class AddMedicWindow : Window
    {
        public AddMedicWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var name = Name.Text.Trim();
            var cost = Cost.Text.Trim();
            var count = Count.Text.Trim();
            var price = Price.Text.Trim();
            var category = Category.Text.Trim();
            Medic.AddEntry(name, cost, count, price,category);
        }
    }
}
