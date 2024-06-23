using System.ComponentModel.DataAnnotations;

namespace AlBaseet.Core.Entities;

public class User
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }

    public string? RecoveryPhrase { get; set; }
    [Required]
    public Role UserRole { get; set; }
}

public enum Role
{
    Admin,
    Employee
}