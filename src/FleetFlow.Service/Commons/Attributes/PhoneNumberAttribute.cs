using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FleetFlow.Service.Commons.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PhoneNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is null || string.IsNullOrEmpty(value.ToString()))
                return new ValidationResult("Phone number can't be null");

            Regex regex = new Regex("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$");

            return regex.Match(value.ToString()).Success ? ValidationResult.Success :
                new ValidationResult("Enter the valid phone number.");
        }

    }
}
