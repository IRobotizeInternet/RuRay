
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RobotizeFacebook.Utilities
{
    public class Json
    {
        public void Deserialize<T>(string fileName)
        {
            var jsonString = File.ReadAllText(fileName);
            var weatherForecast = JsonSerializer.Deserialize<T>(jsonString);
        }

        public static void SerializeAsync<T>(string fileName, T obj)
        {
            FileStream createStream = File.Create(fileName);
            JsonSerializer.SerializeAsync(createStream, obj);
        }
    }
}
