using ProductAccApplication;
using ProductAccDomain;
using ProductAccInfra.Common;

namespace ProductAccInfra
{
    public class TestRepo : ITestRepo
    {
        private readonly AppDbContext _con;

        public TestRepo(AppDbContext con)
        {
            _con = con;
        }

        public async Task<string> InsertIntoTest(TestClean rval)
        {
            await _con.TestClean.AddAsync(rval);
            await _con.SaveChangesAsync();
            if(rval.Id >0)
            {
                return "Success";
            }
            else
            {
                return "Failed";
            }
            
        }
    }
}