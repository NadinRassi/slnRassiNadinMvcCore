using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class CategoriaDesayunoAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            string categoria = Convert.ToString(value);

            if (categoria.ToUpper() != "DESAYUNO")
            {
                return new ValidationResult("El nombre de la categoria debe ser desayuno!");
            }

            return ValidationResult.Success;

        }
    }
}
