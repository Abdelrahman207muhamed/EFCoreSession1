using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession1.Entities
{

    //Entity
    //POCO :
    //Plan Old CLR Object

    //internal class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int  Age { get; set; }
    //    public double Salary { get; set; }//Value Type :float[Salary]-Required
    //    public string? Email { get; set; }//nvarachar(max)-Optional
    //    public DateTime DateOfCreation { get; set; } //datetime2- Required

    //}




    //2.Data Annotation
    //[Table("Hamada",Schema ="dbo")]
    class Employee 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; }

        [Required]
        [Column("EmpName",TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50,MinimumLength=10)]
        public string? Name { get; set; }

        [Range(20,60)]
        public int? Age { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }//Example@Example.Com
        
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        
        [Column(TypeName="money")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }
        
        [NotMapped]
        public double TotalSalary { get; set; }

        public string Password { get; set; }
    }
}
