using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryFilesForEver.Clases
{
    internal class ManageJson
    {

        public static List<Element> Leer(String path)
        {
            JArray arrayElements = JArray.Parse(File.ReadAllText(path, Encoding.Default));
            List<Element> elements = arrayElements.ToObject<List<Element>>();

            return elements;
        }

        public static void Escribir(List<Element> elements, String path)
        {
            JArray arrayElements = (JArray)JToken.FromObject(elements);
            File.WriteAllText(path, arrayElements.ToString());
        }
    }
}

