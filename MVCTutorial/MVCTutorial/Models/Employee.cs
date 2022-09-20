using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    public class Employee
    {
        [Required(ErrorMessage="This field is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [CustomValidator]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1,100)]
        public int Salary { get; set; }
    }
}