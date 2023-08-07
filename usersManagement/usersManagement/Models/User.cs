using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
[BsonIgnoreExtraElements]
public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]//Convert mongo id data type to string .net
    public string Id { get; set; } = String.Empty;

    [BsonElement("name")]
    public string Name { get; set; } = String.Empty;

    [BsonElement("firstlastname")]
    public string Firstlastname { get; set; } = String.Empty;

    [BsonElement("secondlastname")]
    public string Secondlastname { get; set; } = String.Empty;

    [BsonElement("address1")]
    public string Address1 { get; set; } = String.Empty;

    [BsonElement("address2")]
    public string Address2 { get; set; } = String.Empty;

    [BsonElement("city")]
    public string City { get; set; } = String.Empty;

    [BsonElement("state")]
    public string State { get; set; } = String.Empty;

    [BsonElement("zipcode")]
    public string Zipcode { get; set; } = String.Empty;

    [BsonElement("email")]
    public string Email { get; set; } = String.Empty;

    [BsonElement("specialty")]
    public string Specialty { get; set; } = String.Empty;

    [BsonElement("contactedby")]
    public bool Contactedby { get; set; }

    [BsonElement("age")]
    public int Age { get; set; }

    [BsonElement("interests")]
    public string[]? Interests { get; set; }
}



