using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace StudentDataModels.Importers
{
    // A transistion class to store data that cannot be directly mapped 
    // from Json into the final object 
    class JsonTransitionModel
    {
        [JsonExtensionData]
        public Dictionary<string, JsonElement> JsonExtensionData { get; set; }

        public static DateTime DateFromDict(
            Dictionary<string, JsonElement> jsonData,
            string property)
        {
            string dateString = jsonData[property].ToString();
            return Convert.ToDateTime(dateString);
        }

        public static string StringFromDict(
            Dictionary<string, JsonElement> jsonData,
            string property) =>
            jsonData[property].ToString();

        public static string StringFromElem(JsonElement element, string property) =>
            element.GetProperty(property)
                .ToString();

        public static int IntFromElem(JsonElement element, string property) =>
            element.GetProperty(property)
                .GetInt32();

        public static bool BoolFromElem(JsonElement element, string property) =>
            element.GetProperty(property)
                .GetBoolean();
    }
}
