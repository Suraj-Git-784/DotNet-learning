using ModelsAsp.Models;

namespace ModelsAsp.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().FirstOrDefault(x => x.rollNo == id);
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                 new StudentModel
                {
                    rollNo = 1,
                    Name = "Suraj",
                    Gender = "Male",
                    Standard = 11
                },
                new StudentModel
                {
                    rollNo = 2,
                    Name = "Ronik",
                    Gender =  "Male",
                    Standard = 12
                },
                new StudentModel
                {
                    rollNo = 3,
                    Name = "Harshit",
                    Gender = "Male",
                    Standard = 10
                }
            };
        }
    }
}
