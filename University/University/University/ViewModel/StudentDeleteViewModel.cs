using System.ComponentModel.DataAnnotations;

namespace University.ViewModel
{
    public class StudentDeleteViewModel
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
}
