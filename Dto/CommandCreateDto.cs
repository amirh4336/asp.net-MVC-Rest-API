using System.ComponentModel.DataAnnotations;

namespace _.Dto;

public class CommandCreateDto
{
    [Required] [MaxLength(250)] public string HowTo { get; set; }

    [Required] public string Line { get; set; }

    [Required] public string Platform { get; set; }
}