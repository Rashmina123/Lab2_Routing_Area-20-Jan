using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Lab2_Routing_Area_20_Jan.Attributes
{
    public class ValidateCheckBox : ValidationAttribute,IClientModelValidator
    {

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-chkbox", ErrorMessage);
        }

        public override bool IsValid(object? value)
        {
            return (bool)value;
        }
    }
}
