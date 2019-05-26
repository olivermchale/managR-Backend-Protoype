using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SysIO = System.IO;
using System.Text;
using managR.JsonHelpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using Microsoft.AspNetCore.Cors;

namespace ManagR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {

        private string v = "";
        JsonSerializer serializer = new JsonSerializer();
       
        // GET api/board
        [HttpGet]
        public ActionResult<BoardJson> Get()
        {
            using (StreamReader r = new StreamReader(@"C:\Users\Oliver\source\repos\ManagR\ManagR\board.json"))
            {
                string json = r.ReadToEnd();
                var boardJson = BoardJson.FromJson(json);
                return boardJson;
            }
        }
    }
}
