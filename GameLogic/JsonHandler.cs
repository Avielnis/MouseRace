using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace GameLogic
{
    public class JsonHandler
    {
        private string FilePath { get; set; }
        private List<ElementJsonData> ElementsList { get; set; }

        public JsonHandler(string filePath)
        {
            this.FilePath = filePath;
            ElementsList = new List<ElementJsonData>();
        }

        public List<ElementJsonData> LoadJsonData()
        {
            try
            {
                string jsonString = File.ReadAllText(FilePath);
                RootObject rootObject = JsonSerializer.Deserialize<RootObject>(jsonString);
                ElementsList = rootObject.ElementsJson;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ElementsList;
        }
    }

    public class ElementJsonData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("speed")]
        public double Speed { get; set; }
    }

    public class RootObject
    {
        [JsonPropertyName("elements")]
        public List<ElementJsonData> ElementsJson { get; set; }
    }
}
