using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Authorisation
    {
        private readonly static MedicationAccountingContext context = new MedicationAccountingContext();
        public static bool Login(string login, string password)
        {
            var client = context.Clients.FirstOrDefault(u => u.Login == login && u.Password == password);

            if (client == null)
            {
                return false;
            }

            return true;
        }
    }
}
