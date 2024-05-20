using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Catalog.Entities
{
    public class Location
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Floor { get; set; }

        public string Block { get; set; }

        public string Shelf { get; set; }

        public string Part { get; set; }

    }
}
