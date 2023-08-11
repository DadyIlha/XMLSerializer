using System.Xml.Serialization;

namespace XMLSerializer.Models;

public class Body
{
    [XmlElement("GetAccountsByAccountNameResponse", Namespace = "http://ibsolution.com.br")] public GetAccountsByAccountNameResponse GetAccountsByAccountNameResponse { get; set; } = new GetAccountsByAccountNameResponse();
}


[XmlRoot("Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class Envelope
{
    private static XmlSerializerNamespaces namespaces;
    [XmlNamespaceDeclarations] public XmlSerializerNamespaces xmlns { get { return namespaces; } set { } }

    static Envelope()
    {
        namespaces = new XmlSerializerNamespaces();
        namespaces.Add("soap", "http://schemas.xmlsoap.org/soap/envelope/");
    }
    [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public Body Body { get; set; } = new Body();
}
