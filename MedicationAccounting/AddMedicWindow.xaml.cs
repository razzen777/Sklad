using Services;
using Storage;
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
        private readonly static MedicationAccountingContext context = new MedicationAccountingContext();
        private Medicament _currentMedicament=new Medicament();
        DataGrid DataGrid = new DataGrid();
        public AddMedicWindow(DataGrid dataGrid)
        {
            InitializeComponent();
            DataGrid = dataGrid;
        }
        public AddMedicWindow(Medicament medicament=null)
        {
            InitializeComponent();
            if (medicament != null)
            {
                _currentMedicament=medicament;
            }
            DataContext = _currentMedicament;
        }   
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var name = Name.Text.Trim();
            var cost = Cost.Text.Trim();
            var count = Count.Text.Trim();
            var price = Price.Text.Trim();
            var category = Category.Text.Trim();
            Medic.AddEntry(name, cost, count, price,category);
            DataGrid.ItemsSource = Medic.GetMedicamentList();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            _currentMedicament.MedicamentName = Name.Text.Trim();
            _currentMedicament.Price = Price.Text.Trim();
            _currentMedicament.Count=Count.Text.Trim();
            _currentMedicament.Cost=Cost.Text.Trim();
            _currentMedicament.CategoryName=Category.Text.Trim();
            context.SaveChanges();
            DataGrid.ItemsSource = Medic.GetMedicamentList();
        }
    }
}
