using System.ComponentModel.DataAnnotations;
namespace StudentManagementWebAPI;
public class Student
{
    
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Course is required.")]
    public string Course { get; set; }

    [Range(1, 120, ErrorMessage = "Age must be between 1 and 120.")]
    public int Age { get; set; }
}