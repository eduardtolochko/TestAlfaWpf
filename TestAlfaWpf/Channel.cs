using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestAlfaWpf
{
        [Serializable()]
        public class Item
        {
            [XmlElement("title")]
            public string title { get; set; }

            [XmlElement("link")]
            public string link { get; set; }

            [XmlElement("description")]
            public string description { get; set; }

            [XmlElement("category")]
            public string category { get; set; }

            [XmlElement("pubDate")]
            public string pubDate { get; set; }

            
        }

        [XmlRootAttribute("channel")]
        public class Channel
        {
            [XmlElement("item")]
            public Item[] ChannelList { get; set; }
        }


}
