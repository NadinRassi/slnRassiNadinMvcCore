using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class EdadMayorA18Attribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int edad = Convert.ToInt32(value);


            if (edad < 18)
            {
                return new ValidationResult("La edad debe ser mayor a 18.");
            }

            return ValidationResult.Success;

        }

    }
}
