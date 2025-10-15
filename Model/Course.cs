using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace project.Model
{
  public class Course
  {
    [Key]
    public int Id { get; set; }
    [Required]
    [MinLength(3)]
    public string Title { get; set; }
	
	public string Exerpt { get; set; }
	
    public string? Description { get; set; }
	
	public DateTime DateCreated { get; set; } = DateTime.Now;
  [Required]
  public string ImageUrl { get; set; }
  [ValidateNever]
  public List<Comment> Comments { get; set; }


    [Required]
    public int InstructorId { get; set; }
    [ValidateNever]
    public Instructor Instructor { get; set; }
    [ValidateNever]
    public List<Student> Students { get; set; }
    
    
  }
}