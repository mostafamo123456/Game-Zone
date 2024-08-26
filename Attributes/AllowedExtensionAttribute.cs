using System.ComponentModel.DataAnnotations;

namespace GameZone.Attributes
{
    public class AllowedExtensionAttribute:ValidationAttribute
    {
        private readonly string allowedExtension;
        public AllowedExtensionAttribute(string allowedExtension) 
        {
            this.allowedExtension = allowedExtension;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file is not  null)
            {
                var extension =Path.GetExtension(file.FileName);
                 var isAllowed = allowedExtension.Split(',').Contains(extension,StringComparer.OrdinalIgnoreCase );
                if (!isAllowed) 
                {
                    return new ValidationResult(errorMessage:$"Only {allowedExtension} are allowed");
                }
            }
            return ValidationResult.Success;
            
        }
    }
}
