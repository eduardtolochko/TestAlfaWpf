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
        public Window1()
        {
            InitializeComponent();
        }
            private void XMLDataBase(object sender, RoutedEventArgs e)
            ///Read data from a file using a data model.
            {
                channelList = ReadData.ReadXMLDataBase().ChannelList;
            }

            private void XMLRegularExpressions(object sender, RoutedEventArgs e)
            ///Read data from a file using regular expressions
            {
                channelList = ReadData.ReadXMLRegularExpressions().ChannelList;
            }

            private void AddExel(object sender, RoutedEventArgs e)
            ///Write data to excel
            {
                WriteData.WriteAddExel(channelList);
                channelList = null;
            }

            private async void AddWord(object sender, RoutedEventArgs e)
            ///Write data to word
            {
                WriteData.WriteAddWord(channelList);
                channelList = null;
            }
            private async void AddTxt(object sender, RoutedEventArgs e)
            ///Write data to txt
            {
                WriteData.WriteAddTxt(channelList);
                channelList = null;
            }
    }
}
