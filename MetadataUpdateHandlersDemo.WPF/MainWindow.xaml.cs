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
        public MainWindow()
        {
            InitializeComponent();

            HotReloadService.UpdateApplicationEvent += HotReloadService_UpdateApplicationEvent;
        }

        private void HotReloadService_UpdateApplicationEvent(Type[]? obj)
        {
            Debug.WriteLine("MetadataUpdateHandler - WPF");
        }

        private void buttonTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test 2");
        }
    }
}
