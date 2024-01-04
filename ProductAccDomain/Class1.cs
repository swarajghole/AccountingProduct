using System.ComponentModel.DataAnnotations;

namespace ProductAccDomain
{
    public class TestClean
    {
        [Key]
        public int Id { get; set; }
        public string RValue { get; set; }

    }
}