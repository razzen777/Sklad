using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Medic
    {
        private readonly static MedicationAccountingContext context = new MedicationAccountingContext();
        public static void AddEntry(string name, string cost, string count, string price, string category)
        {
            var date = DateTime.Now.ToString();
            var medicament = new Medicament
            {
                MedicamentName = name,
                Cost = cost,
                Price = price,
                Count = count,
                Date = date,
                CategoryName = category
            };
            context.Medicaments.Add(medicament);
            context.SaveChanges();
        }
        public static IEnumerable<Medicament> GetMedicamentList()
        {
            return context.Medicaments.ToList();
        }
    }
}
