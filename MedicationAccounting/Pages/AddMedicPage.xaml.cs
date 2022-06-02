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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Services;
using Storage;

namespace MedicationAccounting.Pages
{
    /// <summary>
    /// Логика взаимодействия для MedicListPage.xaml
    /// </summary>
    public partial class MedicListPage : Page
    {
        private readonly static MedicationAccountingContext context = new MedicationAccountingContext();
        AddMedicWindow medicWindow;
        public MedicListPage()
        {
            InitializeComponent();
            MedicDataGrid.ItemsSource = Medic.GetMedicamentList();
            medicWindow=new AddMedicWindow(MedicDataGrid);
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            medicWindow = new AddMedicWindow((sender as Button).DataContext as Medicament);
            medicWindow.Show();
        }
        private void AddMedic_Click(object sender, RoutedEventArgs e)
        {
            medicWindow.Show();
        }

        private void DeleteMedic_Click(object sender, RoutedEventArgs e)
        {
            var medicaments=MedicDataGrid.SelectedItems.Cast<Medicament>().ToList();
            foreach (var item in medicaments)
            {
                context.Medicaments.Attach(item);
            }
            context.Medicaments.RemoveRange(medicaments);
            context.SaveChanges();
            MedicDataGrid.ItemsSource=Medic.GetMedicamentList();
        }
    }
}
