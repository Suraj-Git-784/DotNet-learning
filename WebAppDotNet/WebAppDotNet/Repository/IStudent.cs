using WebAppDotNet.Models;

namespace WebAppDotNet.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);
    }
}
