using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CookingRecipeBookProject
{
    public class MinimizedRecipe
    {
        [BsonId] public ObjectId Id { get; set; }
        [BsonElement("title")] public String Title { get; set; }
        [BsonElement("summary")] public String Summary { get; set; }
        [BsonElement("image")] public String ImageUrl { get; set; }
        [BsonElement("category")] public String Category { get; set; }
    }
}