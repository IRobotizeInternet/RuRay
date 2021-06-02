﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace RuRayFacebook.Utilities
{
    public class FileOperations
    {
        public static T Deserialize<T>(string fileName)
        {
            if (File.Exists(fileName) == false)
            {
                return default;
            }

            var jsonString = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public static void Serialize(string fileName, List<ClassDefinationDTO> obj)
        {
            var jsonString = JsonConvert.SerializeObject(obj);
            File.WriteAllText(fileName + DateTime.Now.Ticks + ".json", jsonString);
            //File.AppendAllText(@"D:\Dev\RuRay\RuRayFacebook\Services\RuRayAPIs\JsonClasses11637487615946264758.json", jsonString);
            File.AppendAllText(fileName, jsonString);
        }

        public static void Serialize<T>(string fileName, T obj)
        {
            var jsonString = JsonConvert.SerializeObject(obj);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
