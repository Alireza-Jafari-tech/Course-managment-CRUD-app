using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace project.Model
{
  public class Comment
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    
    public string? Email { get; set; }
    [Required]
    [Display(Name= "Comment")]
    [StringLength(600, MinimumLength = 3, ErrorMessage = "text must be between 3 to 600 characters")]
    public string CommentText { get; set; }
    [Required]
    public int CourseId { get; set; }
    [Display(Name= "Date")]
    public DateTime CommentDate { get; set; } = DateTime.Now;
    
    
  }
}