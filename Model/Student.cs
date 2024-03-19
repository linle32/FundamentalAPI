using System.ComponentModel.DataAnnotations;

namespace FundamentalAPI.Model
{
    public class Student
    {
        public int Id { get; set; }
        
        [MaxLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Name { get; set; }
    }
}
