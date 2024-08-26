using System.ComponentModel.DataAnnotations;

namespace GameZone.Attributes
{
    public class MaxFileSizeAttribute:ValidationAttribute
    {
        private readonly int maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            this.maxFileSize = maxFileSize;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file is not null && file.Length> maxFileSize)
            {
                return new ValidationResult(errorMessage: $"Maximum allowed size {maxFileSize} byte");
                
            }
            return ValidationResult.Success;
        }
    }
}
