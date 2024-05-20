using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Catalog.Entities
{
    public class Book
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Year { get; set; }

        public string Description { get; set; }

        [BsonIgnore]
        public string CategoryId { get; set; }

        [BsonIgnore]
        public string LocationId { get; set; }

    }
}
