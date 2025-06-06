using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDTO
{
    [Required]
    public required String Username { get; set; }
    [Required]
    public required String Password { get; set; }
}
