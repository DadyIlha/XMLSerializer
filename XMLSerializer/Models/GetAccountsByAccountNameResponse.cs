
using System.Xml.Serialization;

namespace XMLSerializer.Models;


[XmlType(TypeName = "GetAccountsByAccountNameResponse")]
public class GetAccountsByAccountNameResponse
{
    [XmlElement(ElementName = "GetAccountsByAccountNameResult")]
    public Account GetAccountsByAccountNameResult { get; set; } = new Account();
}
