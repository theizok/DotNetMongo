using MongoDB.Driver;
using BackChat.Models;
namespace BackChat.Data
{
    public class MongoConnection{

    private readonly IMongoDatabase _database;

    public MongoConnection(){
        var client = new MongoClient("mongodb://localhost:27017");
        _database = client.GetDatabase("Chat");
    }

    public IMongoCollection<Publication> GetPublicationCollection(){
        return _database.GetCollection<Publication>("Publication");
    }
    

}
}


