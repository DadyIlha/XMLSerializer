using System.Xml.Serialization;

namespace XMLSerializer.Models;


//[XmlType(TypeName = "GetAccountsByAccountNameResult")]
public class Account
{
    public string Name { get; set; } = null!;
    public string City { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string EmployeesNr { get; set; } = null!;
    public string ContactName { get; set; } = null!;
    public string ContactEmail { get; set; } = null!;
    public string ContactPhone { get; set; } = null!;
    [XmlArray("Accounts")][XmlArrayItem("Account")] public List<Account> Accounts { get; set; } = new List<Account>();
}

