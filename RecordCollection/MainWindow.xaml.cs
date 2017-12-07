using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.ComponentModel;

namespace RecordCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSort(object sender, SelectionChangedEventArgs e)
        {
            OnSort(sender, e as RoutedEventArgs);
        }

        private void OnSort(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as ViewModel;
            var view = CollectionViewSource.GetDefaultView(viewModel.Records);
            view.SortDescriptions.Clear();
            if (_sortField.SelectedValue != null && _ascending != null)
                view.SortDescriptions.Add(new SortDescription((string)
                 _sortField.SelectedValue, _ascending.IsChecked == true ?
                 ListSortDirection.Ascending :
                 ListSortDirection.Descending));
        }

        private void OnFilter(object sender, TextChangedEventArgs e)
        {
            var viewModel = DataContext as ViewModel;
            var view = CollectionViewSource.GetDefaultView(viewModel.Records);
            if (string.IsNullOrWhiteSpace(_filterText.Text))
                view.Filter = null;
            else
                view.Filter = obj => ((Model.Record)obj).Title.IndexOf(_filterText.Text, StringComparison.InvariantCultureIgnoreCase) > -1
                || ((Model.Record)obj).Artist.IndexOf(_filterText.Text, StringComparison.InvariantCultureIgnoreCase) > -1
                || ((Model.Record)obj).Year.ToString().IndexOf(_filterText.Text, StringComparison.InvariantCultureIgnoreCase) > -1;
        }
    }
}
