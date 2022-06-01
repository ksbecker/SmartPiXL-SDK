using System.Globalization;
using System.Xml.Serialization;

namespace SmartPixl.Sdk;

/// <remarks/>
[Serializable]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
public class SmartPiXLAPIModel
{
    [XmlElement(ElementName = "Date")] public string? DateString { get; set; }

    [XmlElement(ElementName = "NotTheDate")]
    public DateTime Date
    {
        get => DateTime.Parse(DateString);
        set => DateString = value.ToString(CultureInfo.InvariantCulture);
    }

    /// <remarks/>
    public string HTTP_REFERER { get; set; } = default!;

    /// <remarks/>
    public string HTTP_USER_AGENT { get; set; } = default!;

    /// <remarks/>
    public string REQUEST_URI { get; set; } = default!;

    /// <remarks/>
    public string Reseller { get; set; } = default!;

    /// <remarks/>
    public string Client { get; set; } = default!;

    /// <remarks/>
    public string Zip { get; set; } = default!;

    /// <remarks/>
    public string EMail { get; set; } = default!;

    /// <remarks/>
    public string FirstName { get; set; } = default!;

    /// <remarks/>
    public string MI { get; set; } = default!;

    /// <remarks/>
    public string LastName { get; set; } = default!;

    /// <remarks/>
    public string Suffix { get; set; } = default!;

    /// <remarks/>
    public string Address { get; set; } = default!;

    /// <remarks/>
    public string City { get; set; } = default!;

    /// <remarks/>
    public string State { get; set; } = default!;

    /// <remarks/>
    public string Plus_4 { get; set; } = default!;

    /// <remarks/>
    public string CountyName { get; set; } = default!;

    public string First_Seen { get; set; } = default!;

    /// <remarks/>
    public string Last_Seen { get; set; } = default!;

    /// <remarks/>
    public string RecordID { get; set; } = default!;
}