using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string LastName { get; set; }

        [Column("FirstName")]
        public string FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        //mis on ICollection?
        //ICollection on nimekiri kuhu saab panna mitu objekti aga ei pea
        public ICollection<CourseAssignment> CourseAssignments { get; set; }

        //miks siin ei kasutada ICollection, vaid lihtsalt OfficeAssignment?
        //Sest OfficeAssignment on üks-ühele seos Instructoriga, st iga õpetaja
        //võib omada ainult ühte kontorinrinda. Seega ei ole vaja kasutada
        //ICollectioni, kuna ei ole vaja hoida mitut OfficeAssignment objekti.
        //Kui kasutaksime ICollectioni, siis see tähendaks, et õpetaja
        //võiks omada mitut kontorinrinda, mis ei ole meie mudelis korrektne.
        public OfficeAssignment OfficeAssignments { get; set; }
    }
}
