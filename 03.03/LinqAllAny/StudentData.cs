namespace LinqAllAny
{
    public class StudentData
    {
        public static readonly List<Student> students = new List<Student>()
        {
            new Student() {StudentId  = 1, Name = "John", Age = 18},
            new Student() {StudentId  = 2, Name = "Moin", Age = 21},
            new Student() {StudentId  = 3, Name = "Bill", Age = 18},
            new Student() {StudentId  = 4, Name = "Ram", Age = 20},
            new Student() {StudentId  = 5, Name = "Ron", Age = 15},
        };
    }
}
