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
using System.Windows.Shapes;
using static TestAlfaWpf.Push;

namespace TestAlfaWpf
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Channel[] channelList;
        private ReadData readData;

        public object WriteData { get; private set; }

        public Window1()
        {
            InitializeComponent();
            readData = new ReadData();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async Task XMLDataBase(object sender, RoutedEventArgs e)
            ///Read data from a file using a data model.
            {
                channelList = await readData.ReadXML().ChannelList;

            }

            private async Task XMLRegular(object sender, RoutedEventArgs e)
            ///Read data from a file using regular expressions
            {
                channelList = ReadData.ReadXMLRegular().ChannelList;
            }

            private async Task AddExel(object sender, RoutedEventArgs e)
            ///Write data to excel
            {
                WriteData.WriteAddExel(channelList);
                channelList = null;
            }

            private async Task AddWord(object sender, RoutedEventArgs e)
            ///Write data to word
            {
                WriteData.WriteAddWord(channelList);
                channelList = null;
            }
            private async Task AddJson(object sender, RoutedEventArgs e)
            ///Write data to txt
            {
                WriteData.WriteAddJson(channelList);
                channelList = null;
            }
    }
}
