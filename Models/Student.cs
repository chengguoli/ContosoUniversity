using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID {get;set;}
 
        [StringLength(50,MinimumLength=1)]
        [Display(Name="Last Name")]
        public string LastName {get;set;}
        [Required]
        [StringLength(50, ErrorMessage = "First Name cannot longer than 50 chars")]
        [Display(Name = "First Name")]
        [Column("FirstName")]
        public string FirstMidName {get; set;}
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode=true)]
        [Display(Name = "Enrollment Date")]
        public  DateTime EnrollmentDate {get; set;}
        public string FullName 
        {
            get {
                return LastName + "," + FirstMidName;
            }
        }
        public ICollection<Enrollment> Enrollments {get; set;}
    }
}