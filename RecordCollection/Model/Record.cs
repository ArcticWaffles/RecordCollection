using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RecordCollection.Model
{
    public class Record
    {
        public Record(string artist, string title, int year, Uri imageSource)
        {
            Artist = artist;
            Title = title;
            Year = year;
            CoverImage = new BitmapImage(imageSource);
        }

        public string Artist { get; }

        public string Title { get; }

        public int Year { get; }

        public BitmapImage CoverImage { get; }
    }
}
