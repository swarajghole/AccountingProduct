using ProductAccDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccApplication
{
    public interface ITestRepo
    {
        Task<string> InsertIntoTest(TestClean rval);
    }
}
