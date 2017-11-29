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

namespace RecordCollection.View
{
    /// <summary>
    /// Interaction logic for Record.xaml
    /// </summary>
    public partial class Record : UserControl
    {
        public Record()
        {
            InitializeComponent();
        }

        public Model.Record Source
        {
            get { return (Model.Record)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(Model.Record), typeof(Record), new PropertyMetadata());

    }
}
