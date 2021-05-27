using System.IO;
using System.Xml.Serialization;

namespace XmlExport.Model.Infrastructure
{
    public class XmlCustomSerializer
    {

        public void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            using (var fs = new FileStream(fileName, FileMode.Create))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(fs, serializableObject);
            }
        }

        public T DeserializeObject<T>(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName)) { return default; }

            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(fs);
            }
        }

    }
}
