using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace BackChat.Models{

    public class Publication
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? PublicationId { get; set; } 

        public string author { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }

        public Publication(string author ,string content, DateTime date)
        {
            this.author = author;
            this.content = content;
            this.date = date;
        }

        public Publication(){
            
        }
    }

}
