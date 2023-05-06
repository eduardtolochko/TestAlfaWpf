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

        public Window1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void XMLDataBase(object sender, RoutedEventArgs e)
            ///Read data from a file using a data model.
            {
                channelList = ReadData.ReadXML().ChannelList;
            }

            private void XMLRegularExpressions(object sender, RoutedEventArgs e)
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
                WriteData.WriteAddTxt(channelList);
                channelList = null;
            }
    }
}
