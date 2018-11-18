using System;
using System.Collections.Generic;
using MongoDB.Bson;
using Newtonsoft.Json;
using MongoDB.Bson.Serialization.Attributes;

namespace BostonDevelopment.Models
{

    [BsonIgnoreExtraElements]
    public class Build
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("imgSrc")]
        public string ImgSrc { get; set; }

        [BsonElement("planSrc")]
        public string PlanSrc { get; set; }

        [BsonElement("projectStatus")]
        public string ProjectStatus { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }
       
        [BsonElement("lat")]
        public double? Lat { get; set; }

        [BsonElement("lng")]
        public double? Long { get; set; }

        [BsonElement("neighborhood")]
        public string Neighborhood { get; set; }

        [BsonElement("landSqFt")]
        public string LandSqFt { get; set; }


        [BsonElement("buildingSize")]
        public string buildSize { get; }
 
    }


}
