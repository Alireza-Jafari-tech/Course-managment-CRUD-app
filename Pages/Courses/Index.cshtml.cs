using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Page.Courses
{
  public class IndexModel : PageModel
  {
    private readonly AppDbContext _context;

    public List<Course> Courses { get; set; }

    public IndexModel(AppDbContext context)
    {
      _context = context;
    }

    public void OnGet()
    {
      Courses = _context.Courses
                                .Include("Instructor")
                                .Include("Students")
                                .ToList();
    }

    public void OnPost()
    {
      
    }
  }
}