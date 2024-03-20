using FundamentalAPI.OOP_Example;

namespace FundamentalAPI.OOP_Example
{
    public class StudentGrade8 : Student
    {
    }
}

public class Test
{
    public void testArrtribute()
    {
        var studentGrade8 = new StudentGrade8()
        {
            Name = "Test",
            Age = 1,
            GPA = 2,
        };

        var student = new Student()
        {
            Name = "Test",
            Age = 1,
            GPA = 2,
        };

        var person = new Person();

        var techer = new Teacher();


        var people = new List<Person>();
        people.Add(student);
        people.Add(person);
        people.Add(studentGrade8);


        var students = new List<Student>();
        students.Add(student);
        students.Add(studentGrade8);


    }
}

// Person -> Student -> StudentGrade8 -> ........
