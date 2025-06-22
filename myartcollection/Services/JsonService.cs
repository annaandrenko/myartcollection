using System.IO;
using Newtonsoft.Json;
using myartcollection.Models;
using System.Xml;

namespace myartcollection.Services
{
    public static class JsonService
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data", "materials.json");

        public static MaterialCollection Load()
        {
            if (!File.Exists(FilePath))
                return new MaterialCollection();

            var json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<MaterialCollection>(json)
                   ?? new MaterialCollection();
        }

        public static void Save(MaterialCollection data)
        {
            var json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
    }
}