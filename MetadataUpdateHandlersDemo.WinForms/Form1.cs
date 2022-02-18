using MetadataUpdateHandlersDemo.Shared;
using System.Diagnostics;

namespace MetadataUpdateHandlersDemo.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

#if DEBUG
            HotReloadService.UpdateApplicationEvent += HotReloadService_UpdateApplicationEvent;
#endif
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

#if DEBUG
        private void HotReloadService_UpdateApplicationEvent(Type[]? obj)
        {   
            LoadData();
            Debug.WriteLine("MetadataUpdateHandler - WinForms");
            
        }
#endif

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void LoadData()
        {
            // You can change the list below and upon applying .NET Hot Reload the items will load without UI interaction needed

            List<string> ListOfString = new List<string>();
            ListOfString.Add("Item A");
            ListOfString.Add("Item B");
            ListOfString.Add("Item C");
            ListOfString.Add("Item D");
            ListOfString.Add("Item E");

            listBox1.Invoke(() =>
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(ListOfString.ToArray());
            });   
        }

       
    }
}