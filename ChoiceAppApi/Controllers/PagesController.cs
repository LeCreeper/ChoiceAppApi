using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChoiceAppApi.Data;
using ChoiceAppApi.Model;
using ChoiceAppApi.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChoiceAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {

        readonly PageDataArray  _pageDataArray = new PageDataArray();
        // GET: api/Pages
        [HttpGet]
        public PageData[] Get()
        {
            PageData[] PageData = DBUtility.GetPagesFromDatabase();
            return PageData;
        }

        // GET: api/Pages
        [HttpGet]
        [Route("GetArray")]
        public PageDataArray GetArray()
        {
            return _pageDataArray;
            
        }


        // GET: api/Pages/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pages
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Pages/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
