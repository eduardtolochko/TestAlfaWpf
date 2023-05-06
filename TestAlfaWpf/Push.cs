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
        public static class ReadData
        {
            public static Channel ReadXML()
            {
                Channel channels;

                string path = @"C:\Users\n.tolochka\Downloads\data.xml";

                XmlSerializer serializer = new XmlSerializer(typeof(Channel));

                StreamReader reader = new StreamReader(path);
                channels = (Channel)serializer.Deserialize(reader);
                reader.Close();
                Console.WriteLine("Данные считаны");
                return channels;
            }
            public static async void ReadXMLRegular()
            {
                string path = @"C:\Users\User\Downloads\data.xml";

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
