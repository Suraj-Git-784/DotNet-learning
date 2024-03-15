namespace WebAppDotNet.Models
{
    public class StudentModel
    {
        public int rollNo { get; set; }

        public required string Name { get; set; }

        public required string Gender { get; set; }

        public int Standard { get; set; }
    }
}
