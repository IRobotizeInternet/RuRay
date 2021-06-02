using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace RuRayFacebook.Utilities
{
    /// <summary>
    /// Defines the <see cref="FileOperations" />.
    /// </summary>
    public class FileOperations
    {
        /// <summary>
        /// The Deserialize.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="fileName">The fileName<see cref="string"/>.</param>
        /// <returns>The <see cref="T"/>.</returns>
        public static T Deserialize<T>(string fileName)
        {
            if (File.Exists(fileName) == false)
            {
                return default;
            }

            var jsonString = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        /// <summary>
        /// The Serialize.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string"/>.</param>
        /// <param name="obj">The obj<see cref="List{ClassDefinationDTO}"/>.</param>
        public static void Serialize(string fileName, List<ClassDefinationDTO> obj)
        {
            var jsonString = JsonConvert.SerializeObject(obj);
            File.WriteAllText(fileName + DateTime.Now.Ticks + ".json", jsonString);
            //File.AppendAllText(@"D:\Dev\RuRay\RuRayFacebook\Services\RuRayAPIs\JsonClasses11637487615946264758.json", jsonString);
            File.AppendAllText(fileName, jsonString);
        }

        /// <summary>
        /// The Serialize.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="fileName">The fileName<see cref="string"/>.</param>
        /// <param name="obj">The obj<see cref="T"/>.</param>
        public static void Serialize<T>(string fileName, T obj)
        {
            var jsonString = JsonConvert.SerializeObject(obj);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
