using FundamentalAPI.Model;
using FundamentalAPI.Model.Request;
using FundamentalAPI.Model.Response;
using Microsoft.OpenApi.Validations;

namespace FundamentalAPI.Service
{
    public class StudentService
    {
        public List<GoodStudentResponse> GetGoodStudents(int minGPA)
        {
            var students = Storage.Database.Students;

            return students
                .Where(i => i.GPA > minGPA)
                .Select(i => new GoodStudentResponse()
                {
                    Name = i.Name,
                    GPA = i.GPA,
                })
                .ToList();
        }

        public bool UpdateStudent(int id, UpdateStudentRequest request)
        {
            var students = Storage.Database.Students;

            var student = students.FirstOrDefault(i => i.Id == id);

            if (student == null)
            {
                return false;
            }

            student.Name = request.StudentName;
            student.Age = request.Age;
            student.Address = request.Address;

            return true;
        }


    }
}

/// send queries -> category = shoes database -> database process -> return data
