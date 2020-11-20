using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace task1.Data
{
    [Serializable]
    public class Customer
    {
        private static int amount = 0;
        public int ID {get;}
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }
        public string RegistrationDate { set; get; }

        //public Button Butt { set; get; }
        public static bool operator ==(Customer a, Customer b)
        {
            return a.FirstName == b.FirstName && a.Address == b.Address && a.LastName == b.LastName;
        }
        public static bool operator !=(Customer a, Customer b)
        {
            return !(a.FirstName == b.FirstName && a.Address == b.Address && a.LastName == b.LastName);
        }
        public Customer()
        {
            ID = ++amount;
        }
    }
}
