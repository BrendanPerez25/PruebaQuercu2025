using System.ComponentModel.DataAnnotations;

namespace PruebaQuercu.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}