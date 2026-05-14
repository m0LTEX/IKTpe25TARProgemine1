using System.ComponentModel.DataAnnotations;
using University.Models;

namespace University.ViewModel
{
    public class StudentDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [Display(Name = "Ernollment Date")]
        public DateTime EnrollmentDate { get; set; }
       

        public ICollection<EnrollmentViewModel> EnrollmentsVm { get; set; }
    }

    public class EnrollmentViewModel
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }

        public CourseViewModel CourseVm { get; set; }
    }

    public class CourseViewModel
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
    }
}
