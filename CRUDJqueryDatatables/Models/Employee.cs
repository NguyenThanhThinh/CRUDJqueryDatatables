using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUDJqueryDatatables.Models
{
    public class Employee
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }
        [StringLength(255)]
        public string EmailID { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        [StringLength(255)]
        public string Country { get; set; }
    }
}