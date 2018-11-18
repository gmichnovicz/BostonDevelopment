using System;
namespace BostonDevelopment
{
	public static class Constants
	{
		public static readonly string BuildDb = "Bip";
		public static readonly string BuildCollection = "PlanData";
        public static readonly string MongoConnectionString = "mongodb://gracemichnovicz:xxhj466u@bip-shard-00-00-nxyhs.mongodb.net:27017,bip-shard-00-01-nxyhs.mongodb.net:27017,bip-shard-00-02-nxyhs.mongodb.net:27017/test?ssl=true&replicaSet=Bip-shard-0&authSource=admin&retryWrites=true";
	}
}
