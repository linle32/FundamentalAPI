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
            new Student() { Id = 1, Name = "Duy"}
        };
    }

}
