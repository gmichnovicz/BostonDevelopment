using System;
using System.Collections.Generic;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace BostonBuild.Models
{


    public class Build
    {
        //[JsonProperty(PropertyName = "BuildAddress")]
        public string BuildAddress { get; set; }

        //[JsonProperty(PropertyName = "BuildNeighborhood")]
        public string BuildNeighborhood { get; set; }

        //[JsonProperty(PropertyName = "BuildLandSqFt")]
        public string BuildLandSqFt { get; set; }

        //[JsonProperty(PropertyName = "BuildingSize")]
        public string BuildingSize { get; set; }
        
        //[JsonProperty(PropertyName = "BuildPlanSource")]
        public string BuildPlanSource { get; set; }
        
        //[JsonProperty(PropertyName = "BuildImgSrc")]
        public string BuildImgSrc { get; set; }

        //[JsonProperty(PropertyName = "BuildProjStatus")]
        public string BuildProjStatus { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }


    }

    public class Location
    {
        public float Lat { get; set; }
        public float Long { get; set; }
        //public Location( float lat, float longg)
        //{
        //  Lat = lat;
        //  Long = longg;
        //}

    }
}
