using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordCollection.Model
{
    public class Record
    {
        public Record(string artist, string title, int year)
        {
            Artist = artist;
            Title = title;
            Year = year;
        }

        public string Artist { get; }

        public string Title { get; }

        public int Year { get; }
    }
}
