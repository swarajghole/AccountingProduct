using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAccApplication;
using ProductAccDomain;

namespace ProductAcc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestSer _test;

        public TestController(ITestSer test)
        {
            _test = test;
        }

        [Route("TestInsert")]
        [HttpPost]
        public async Task<string> InsertIntoTest(TestClean rval)
        {
            return await Task.FromResult(await _test.InsertIntoTest(rval));
        }
    }
}
