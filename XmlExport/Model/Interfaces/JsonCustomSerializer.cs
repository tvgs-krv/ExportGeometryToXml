using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace XmlExport.Model.Interfaces
{
    public class JsonCustomSerializer
    {
        public List<RevitMapper> DeserializeJson(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<RevitMapper>>(json);
                return items;
            }
        }

    }
}
