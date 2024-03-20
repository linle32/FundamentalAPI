using System.ComponentModel.DataAnnotations;

namespace FundamentalAPI.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public double GPA { get; set; }

    }
}
