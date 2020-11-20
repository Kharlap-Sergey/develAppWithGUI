using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task1.Data
{
    [Serializable]
    public class CustomersCollection: ObservableCollection<Customer>
    {
        private static string fileToSerialize = "data.xml";
        public void AddItem(Customer item)
        {
            foreach (var it in this.Items)
                if (it.FirstName == item.FirstName && it.LastName == item.LastName)
                {
                    return;
                }
            Add(item);
        }

        public Customer DeleteItem(int ID)
        {
            var item = new Customer();
            foreach (var it in Items)
            {
                if (it.ID == ID)
                {
                    item = it;
                }
            }
            Remove(item);
            return null;
        }
        public void Serialize()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(CustomersCollection));
            DelIfExist(fileToSerialize);
            using (FileStream fs = new FileStream(fileToSerialize, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }
        }

        private void DelIfExist(string file)
        {
           using(var red = new StreamWriter(file))
            {
                red.Write("");
            }
        }

        public void Deserialize()
        {
            try {
                using (FileStream fs = new FileStream(fileToSerialize, FileMode.OpenOrCreate))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(Customer[]));

                    foreach (var c in (Customer[])formatter.Deserialize(fs))
                    {
                        this.Add(c);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
