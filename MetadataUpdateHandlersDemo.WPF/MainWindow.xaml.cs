using MetadataUpdateHandlersDemo.Shared;
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

namespace MetadataUpdateHandlersDemo.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataLoader _dl;

        public MainWindow()
        {
            InitializeComponent();

            _dl = new DataLoader();

#if DEBUG
            HotReloadService.UpdateApplicationEvent += HotReloadService_UpdateApplicationEvent;
#endif
            LoadData(_dl);
        }

#if DEBUG
        private void HotReloadService_UpdateApplicationEvent(Type[]? obj)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                LoadData(_dl); // You need to add this before running the app since "this" can't yet be captured at runtime
                Debug.WriteLine("MetadataUpdateHandler - WPF");
            });
        }
#endif

        private void buttonTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void LoadData(DataLoader dl)
        {
            // You can change the list below and upon applying .NET Hot Reload the items will load without UI interaction needed

            List<string> ListOfString = new List<string>();
            ListOfString.Add("Item A");
            ListOfString.Add("Item B");
            ListOfString.Add("Item C");
            ListOfString.Add("Item D");

            ListOfItems.ItemsSource = ListOfString;
        }
    }
}
