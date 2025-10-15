using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace project.Model
{
  public class Student
  {
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "Your Name must be between 3 to 200 characters")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string Email { get; set; }
    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "your password must be between 3 to 50 characters")]
    public string Password { get; set; }
    [ValidateNever]
    public List<Course> EnrolledCourses { get; set; }
    
    
  }
}