using WebAppDotNet.Models;

namespace WebAppDotNet.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id) => DataSource().FirstOrDefault(x => x.RollNo == id);

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel
                {
                    RollNo = 1,
                    Name = "Suraj",
                    Gender = "Male",
                    Standard = 11
                },
                new StudentModel
                {
                    RollNo = 2,
                    Name = "Ronik",
                    Gender = "Male",
                    Standard = 10
                },
                new StudentModel
                {
                    RollNo = 3,
                    Name = "Harshit",
                    Gender = "Male",
                    Standard = 12
                }
            };
        }
    }
}
