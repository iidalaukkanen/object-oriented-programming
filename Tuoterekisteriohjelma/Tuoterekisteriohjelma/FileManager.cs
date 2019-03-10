using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using Newtonsoft.Json;

namespace Tuoterekisteriohjelma
{
    class FileManager
    {
        private string _filePath;
        private List<OfficeItem> _itemList;

        public FileManager(string filePath)
        {
            _filePath = filePath;
        }

        public void ReadJson()
        {
            StreamReader reader = new StreamReader(_filePath);
            string json = reader.ReadToEnd();
            _itemList = JsonConvert.DeserializeObject<List<OfficeItem>>(json);
            reader.Close();
        }

        public string PrintJson()
        {
            string content = string.Empty;
            foreach (var item in _itemList)
            {
                content += $"Tuote: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}" +
                    $"\n__________________________________________\n";
            }
            return content;
        }

        public void FindItem(int id)
        {
            Console.Clear();
            try
            {
                foreach (var item in _itemList)
                {
                    if (item.Id == id)
                        Console.WriteLine(item.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void PrintByGroup(string group)
        {
            string content = string.Empty;
            Console.Clear();
            Console.WriteLine($"Ryhmän '{group}' tuotteet: \n_______________________________________\n)";
            foreach (var item in _itemList)
            {
                if (item.GroupName == group)
                    Console.WriteLine($"Tuote: {item.Name}\nTuotenumero: {item.Id}\n_________________________________\n");
            }
        }

        public void PrintZeroStock()
        {
            Console.WriteLine("Loppuunmyydyt tuotteet:\n");
            foreach (var item in _itemList)
            {
                if (item.Amount == 0)
                    Console.WriteLine($"Tuote: {item.Name}\nTuotenumero: {item.Id}\n" +
                        $"Tuoteryhmä: {item.GroupName}\n______________________________________________\n");
            }
        }

        public void AddComment(int id)
        {
            foreach (var item in _itemList)
            {
                if (id == item.Id)
                {
                    Console.WriteLine($"Tuotteessa '{item.Name}' on kommentti: {item.Comment}.");
                    Console.Write("Kirjoita uusi kommentti: ");
                    string comment = Console.ReadLine();
                    if (item.Comment.Contains(comment))
                        Console.WriteLine($"Kommentti '{comment}' löytyy jo tuotteesta {item.Name}.");
                    else
                    {
                        item.Comment += " " + comment;
                        Console.WriteLine($"Kommentti '{comment}' lisättiin onnistuneesti tuotteeseen {item.Name}." +
                            $"\nUusi kommentti: {item.Comment}.");
                    }
                }
            }
        }

        public void DeleteComment(int id)
        {
            foreach (var item in _itemList)
            {
                if (id == item.Id)
                {
                    Console.WriteLine($"Tuotteessa '{item.Name}' on kommentti: {item.Comment}");
                    Console.Write("Haluatko poistaa kommentin? K/E");
                    ConsoleKeyInfo cki = Console.ReadKey();

                    if (cki.Key == ConsoleKey.K)
                    {
                        item.Comment = "";
                        Console.WriteLine("\nKommentti poistettu!");
                    }

                    else if (cki.Key == ConsoleKey.E)
                        Console.WriteLine("\nKommenttia ei poistettu.");

                    else
                        Console.WriteLine("\nVäärä syöte! Kommenttia ei poistettu.");
                }
            }
        }

        public void UpdateFile()
        {
            string json = JsonConvert.SerializeObject(_itemList);
            StreamWriter writer = new StreamWriter(_filePath);
            writer.Write(json);
            writer.Close();
        }
    }
}
