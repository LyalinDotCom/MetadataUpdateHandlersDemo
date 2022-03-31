using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MetadataUpdateHandlersDemo.WPF
{
    //[CreateNewOnMetadataUpdate]
    internal class DataLoader
    {
        public async void DoSomethingHere()
        {
            await Task.Delay(1000);
        }

        public async void DoSomethingHere5()
        {
            await Task.Delay(1000);
        }
    }
}
