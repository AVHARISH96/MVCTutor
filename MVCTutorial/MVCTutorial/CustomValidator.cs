using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTutorial
{
    public class CustomValidator:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            if(value != null)
            {
                string message=value.ToString();
                if (message.Contains("Hari"))
                {
                    return ValidationResult.Success;
                }
            }
            ErrorMessage=ErrorMessage??validationContext.DisplayName +"Need to Contain Hari";
            return new ValidationResult(ErrorMessage);
        }
    }
}