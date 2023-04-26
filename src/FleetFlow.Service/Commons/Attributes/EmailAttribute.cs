using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FleetFlow.Service.Commons.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class EmailAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null) return new ValidationResult("Email can not be null.");

        Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        if (regex.Match(value.ToString()).Success)
            return ValidationResult.Success;

        return new ValidationResult("Enter valid email");
    }
}
