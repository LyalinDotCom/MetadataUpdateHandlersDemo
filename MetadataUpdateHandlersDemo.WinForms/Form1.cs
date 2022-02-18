using MetadataUpdateHandlersDemo.Shared;
using System.Diagnostics;

namespace MetadataUpdateHandlersDemo.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            HotReloadService.UpdateApplicationEvent += HotReloadService_UpdateApplicationEvent;
        }

        private void HotReloadService_UpdateApplicationEvent(Type[]? obj)
        {
            Debug.WriteLine("MetadataUpdateHandler - WinForms");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}