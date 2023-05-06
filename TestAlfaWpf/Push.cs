using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestAlfaWpf
{
    public class Push
    {
        public class ReadData
        {
            public async Task <Item> ReadXML()
            {
                Item channel;

                string path = @"data.xml";

                XmlSerializer serializer = new XmlSerializer(typeof(Channel));

                StreamReader reader = new StreamReader(path);
                channel = (Item) serializer.Deserialize(reader);
                reader.Close();

                await Task.Delay(1000);

                Console.WriteLine("Данные считаны");
                return channel;
            }
            public static async Task ReadXMLRegular()
            {
                string path = @"data.xml";

                using (FileStream fstream = File.OpenRead(path))
                {
 
                    byte[] buffer = new byte[fstream.Length];
   
                    await fstream.ReadAsync(buffer, 0, buffer.Length);

                    string textFromFile = Encoding.Default.GetString(buffer);
                    Console.WriteLine($"Текст из файла: {textFromFile}");
                }
            }

        }
    }
}
