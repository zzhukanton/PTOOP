using System;
using System.IO;
using System.Xml.Serialization;

namespace Helpers
{
    public class XmlHelper
    {
        public static TObject DeserializeFromFile<TObject>(string filePath) where TObject : class
        {
            if (!File.Exists(filePath))
            {
                return default(TObject);
            }

            TObject @object;
            var serializer = new XmlSerializer(typeof(TObject), string.Empty);
            using (var reader = new StreamReader(filePath))
            {
                var xsn = new XmlSerializerNamespaces();
                xsn.Add(string.Empty, string.Empty);

                @object = (TObject)serializer.Deserialize(reader);
            }

            return @object;
        }

        public static TObject DeserializeFromFile<TObject>(string filePath, Type[] extraTypes) where TObject : class
        {
            if (!File.Exists(filePath))
            {
                return default(TObject);
            }

            TObject @object;
            var serializer = new XmlSerializer(typeof(TObject), extraTypes);
            using (var reader = new StreamReader(filePath))
            {
                var xsn = new XmlSerializerNamespaces();
                xsn.Add(string.Empty, string.Empty);

                @object = (TObject)serializer.Deserialize(reader);
            }

            return @object;
        }

        public static TObject DeserializeFromStream<TObject>(Stream stream) where TObject : class
        {
            try
            {
                TObject @object;
                var serializer = new XmlSerializer(typeof(TObject), string.Empty);
                using (var reader = new StreamReader(stream))
                {
                    var xsn = new XmlSerializerNamespaces();
                    xsn.Add(string.Empty, string.Empty);

                    @object = (TObject)serializer.Deserialize(reader);
                }

                return @object;
            }
            catch (Exception)
            {
                return default(TObject);
            }
        }

        public static T XmlDeserializeFromString<T>(string objectData)
        {
            return (T)XmlDeserializeFromString(objectData, typeof(T));
        }

        public static object XmlDeserializeFromString(string objectData, Type type)
        {
            var serializer = new XmlSerializer(type);
            object result;

            using (TextReader reader = new StringReader(objectData))
            {
                result = serializer.Deserialize(reader);
            }

            return result;
        }
        public static T XmlDeserializeFromString<T>(string objectData, Type[] extraTypes)
        {
            return (T)XmlDeserializeFromString(objectData, typeof(T), extraTypes);
        }

        public static object XmlDeserializeFromString(string objectData, Type type, Type[] extraTypes)
        {
            var serializer = new XmlSerializer(type, extraTypes);
            object result;

            using (TextReader reader = new StringReader(objectData))
            {
                result = serializer.Deserialize(reader);
            }

            return result;
        }

        public static void Serialize<TObject>(TObject @object, string filePath)
        {
            var writer = new XmlSerializer(typeof(TObject));

            var file = new StreamWriter(filePath);
            writer.Serialize(file, @object);
            file.Close();
        }

        public static string Serialize<TObject>(TObject @object)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(@object.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, @object);
                return textWriter.ToString();
            }
        }

        public static string Serialize<TObject>(TObject @object, Type[] extraTypes)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(@object.GetType(), extraTypes);

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, @object);
                return textWriter.ToString();
            }
        }
    }
}
