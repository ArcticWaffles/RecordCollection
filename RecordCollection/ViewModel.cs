using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordCollection.Model;
using System.Windows.Media.Imaging;

namespace RecordCollection
{
    public class ViewModel
    {
        public ViewModel()
        {
            Records.Add(new Record("Cat Stevens", "Tea for the Tillerman", 1970, new Uri("pack://application:,,,/Images/cats.jpg")));
            Records.Add(new Record("The Beatles", "Help!", 1969, new Uri("pack://application:,,,/Images/cats.jpg")));
            Records.Add(new Record("The Rolling Stones", "Beggars Banquet", 1968, new Uri("pack://application:,,,/Images/cats.jpg")));
            Records.Add(new Record("David Bowie", "Blackstar", 2016, new Uri("pack://application:,,,/Images/cats.jpg")));
        }

        public List<Record> Records { get; set; } = new List<Record>();
    }
}
