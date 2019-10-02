using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MigrationTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var a = new Dictionary<int, string>() { { 1, "1" }, { 2, "2" }, { 3, "test" } };
            var b = new { Id = 1, Name = "test", Contents = a };


            //跑cmd方式
            //var proc1 = new ProcessStartInfo();
            //string anyCommand =
            //    @"E: & cd t & dir & pause";
            //proc1.UseShellExecute = true;
            //proc1.FileName = @"C:\Windows\System32\cmd.exe";
            //proc1.Verb = "runas";
            //proc1.Arguments = "/c " + anyCommand;
            //proc1.WindowStyle = ProcessWindowStyle.Normal;

            //Process.Start(proc1);

            return Ok(b);
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return NoContent();
        }

    }
}
