using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Housing.Properties;
using Newtonsoft.Json;
using System.Text.Json;

namespace Student_Housing
{
    public static class TextFileUtilities
    {     
        public static void WriteToJson<T>(List<T> list, string nameOfJson)
        {
            var json = JsonConvert.SerializeObject(list, Formatting.Indented);

            using (var file = File.Open(GetPath("\\"+nameOfJson+".json"), FileMode.Create))
            {
                using (var writer = new StreamWriter(file))
                {
                    writer.Write(json);
                }
            }
        }
        public static List<T>? GetFromJson<T>(string nameOfJson)
        {
            List<T> students;

            using (StreamReader reader = new StreamReader(GetPath("\\"+nameOfJson + ".json")))
            {
                string jsonString = reader.ReadToEnd();
                students = JsonConvert.DeserializeObject<List<T>>(jsonString);
            }

            if (students == null)
            {
                return new List<T>();
            }
            else
            {
                return students;
            }

        }

        public static string GetPath(string fileName)
        {
            string currentDirectory = Environment.CurrentDirectory;
            string editedCurrentDirectory = currentDirectory.Replace("\\", "\\\\");
            string path = editedCurrentDirectory.Replace(@"bin\\Debug\\net6.0-windows", fileName);
            return path;
        }
        public static List<string> HouseRules()
        {
            string fileLocation = GetPath("house rules.txt");

            List<string> rules = new List<string>();

            rules.Add("1. Smoking is not allowed inside the House");
            rules.Add("2. Close the Window when you leave the House");
            rules.Add("3. Do not turn on the heater when the window is open");
            rules.Add("4. If you are new make sure the smoke detector in your room working");
            rules.Add("5. Do not make loud noise in your garden");

            File.WriteAllLines(fileLocation, rules);

            foreach (string lines in rules)
            {
                Console.WriteLine(lines);
            }
            File.ReadAllLines(fileLocation).ToList();
            return rules;

        }

    }
}
