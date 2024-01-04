using ProductAccDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccApplication
{
    public class TestSer : ITestSer
    {
        private readonly ITestRepo _test;

        public TestSer(ITestRepo test)
        {
            _test = test;
        }
        public async Task<string> InsertIntoTest(TestClean rval)
        {
            return await Task.FromResult(await _test.InsertIntoTest(rval));    
        }
    }
}
