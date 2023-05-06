using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Exсel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using Newtonsoft.Json;
using System.Formats.Tar;

namespace TestAlfaWpf
{
    internal class WriteAdd
    {
        public static void WriteAddWord(Item[] channelList)
        {
            ///Write data to word
            {
                try
                {
                    //Create an instance for word app  
                    Word.Application winword = new Word.Application();

                    //Set animation status for word application  
                    winword.ShowAnimation = false;

                    //Set status for word application is to be visible or not.  
                    winword.Visible = true;

                    //Create a missing variable for missing value  
                    object missing = System.Reflection.Missing.Value;

                    //Create a new document  
                    Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                    if (channelList == null)
                    {
                        Console.WriteLine("Данные из файла не были взяты!");
                        return;
                    }

                    Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);

                    foreach (Item channel in channelList)
                    {
                        para1.Range.Text = $"\t{channel.title} " + Environment.NewLine;
                        para1.Range.Text = $"\t{channel.link}" + Environment.NewLine;
                        para1.Range.Text = $"\t{channel.description} " + Environment.NewLine;
                        para1.Range.Text = $"\t{channel.category} " + Environment.NewLine;
                        para1.Range.Text = $"\t{channel.pubDate}\n\n\n " + Environment.NewLine;
                    }
                    Console.WriteLine("Данные успешно были записаны в Word.docx файл!");
                    channelList = null;


                    //Save the document  
                    object filename = "WordApp.docx";
                    document.SaveAs2(ref filename);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    winword.Quit(ref missing, ref missing, ref missing);
                    winword = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static void WriteAddExel(Item[] channelList)
        ///Write data to excel
        {

        }

        public async Task WriteAddJson(Item[] channelList)
        ///Write data to Json
        {
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                Person tom = new Person("Tom", 37);
                await JsonSerializer.SerializeAsync<Person>(fs, tom);
                Console.WriteLine("Data has been saved to file");
            }

            // чтение данных
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                Person? person = await JsonSerializer.DeserializeAsync<Person>(fs);
                Console.WriteLine($"Name: {person?.Name}  Age: {person?.Age}");
            }

        }
                class Person
                {
                    public string Name { get; }
                    public int Age { get; set; }
                    public Person(string name, int age)
                {
                    Name = name;
                    Age = age;
                }
            }
    
    }
}
