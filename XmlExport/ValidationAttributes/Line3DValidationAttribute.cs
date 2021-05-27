using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlExport.Model;

namespace XmlExport.ValidationAttributes
{
    class Line3DValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return new ValidationResult(Errors.Line3DIsNull);

            var line3D = value as Line3D;

            return ValidationResult.Success;
        }

    }
}
