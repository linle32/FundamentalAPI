using FundamentalAPI.Model;

namespace FundamentalAPI.Storage
{
    public static class Database
    {
        public static List<string> Summaries = new List<string>()
        {
              "Freezing",
              "Bracing",
              "Chilly",
              "Cool",
              "Mild",
              "Warm",
              "Balmy",
              "Hot",
              "Sweltering",
              "Scorching"
        };

        public static List<Student> Students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Duy", GPA = 10},
            new Student() { Id = 2, Name = "Toan", GPA = 9},
            new Student() { Id = 3, Name = "Diep", GPA = 10},
            new Student() { Id = 4, Name = "Duy 2", GPA = 8},
            new Student() { Id = 5, Name = "Toan 2", GPA = 7},
            new Student() { Id = 6, Name = "Diep 2", GPA = 6}

        };
    }

}
