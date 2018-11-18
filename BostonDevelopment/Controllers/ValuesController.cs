using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BostonDevelopment.Models;
using Newtonsoft.Json;
using MongoDB.Driver;
using MongoDB.Bson;
using BostonDevelopment;


namespace BostonDevelopment.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

		private readonly MongoClient _client;
		private readonly IMongoDatabase _db;
		IMongoCollection<Build> _blds;

        public ValuesController()
		{
			_client = new MongoClient(Constants.MongoConnectionString);
            _db = _client.GetDatabase(Constants.BuildDb);
            _blds = _db.GetCollection<Build>(Constants.BuildCollection);
		}

		// GET: api/values
		[HttpGet]
        public IEnumerable<Build> Get()
		{
            return _blds.AsQueryable<Build>().ToList();
		}


		// GET api/values/5
		[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
