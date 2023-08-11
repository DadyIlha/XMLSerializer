// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using System;
using XMLSerializer.Models;

Console.WriteLine("Hello, World!");
string xmlContents = File.ReadAllText("../../../ContasIBS.xml");


try
{
    XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
    StringReader reader = new StringReader(xmlContents);
    Envelope? envelope = (Envelope?)serializer!.Deserialize(reader!);
    reader.Close();
    reader.Dispose();
    Console.WriteLine(envelope!.XMLSerializer());
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
