namespace University.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourdeId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }
        public Course Course 
    }

    public enum Grade
    {
        A, B ,C, D, F
    }
}
