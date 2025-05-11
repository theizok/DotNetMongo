using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using BackChat.Models;
using BackChat.Data;

namespace BackChat.Services{
    public class PublicationService{
        

        public Publication addPublication(Publication publication){
        var mongo = new MongoConnection();
        var publications = mongo.GetPublicationCollection();

        publications.InsertOne(publication);
        return publication;
        }

        public List<Publication> getPublications(){
        var mongo = new MongoConnection();
        var publications = mongo.GetPublicationCollection();

        return publications.Find(_ => true).ToList();
        }



    }
}
