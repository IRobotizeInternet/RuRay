﻿
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace RobotizeFacebook.Utilities
{
    public class Json
    {
        public void Deserialize<T>(string fileName)
        {
            var jsonString = File.ReadAllText(fileName);
            var weatherForecast = JsonConvert.DeserializeObject(jsonString);
        }

        public static void Serialize(string fileName, List<ClassDefinationDTO> obj)
        {
            var jsonString = JsonConvert.SerializeObject(obj);
            File.WriteAllText(fileName+DateTime.Now.Ticks+".json", jsonString);
            File.AppendAllText(@"D:\Dev\Robotize\RobotizeFacebook\Services\RobotizeAPIs\JsonClasses11637487615946264758.json", jsonString);
        }
    }
}