using System.Data.SqlTypes;
using System.Text;
using System.Xml.Serialization;

namespace System;

public static class SerializerServiceExtension
{
    public static string XMLSerializer(this object obj)
    {
        var serializer = new System.Xml.Serialization.XmlSerializer(obj.GetType(), "");
        MemoryStream sw = new MemoryStream()!;
        serializer.Serialize(sw, obj);
        sw.Close();
        var buffer = sw.GetBuffer();
        sw.Dispose();
        return Encoding.UTF8.GetString(buffer);
    }

    public static void XMLDeserializer(this string str, object obj)
    {
        XmlSerializer serializer = new XmlSerializer(obj.GetType());

        using (StringReader reader = new StringReader(str))
        {
            var type = obj.GetType();
            obj = serializer.Deserialize(reader);
        }
    }
}
