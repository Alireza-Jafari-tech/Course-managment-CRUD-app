using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Page.Instructors
{
  public class IndexModel : PageModel
  {
    private readonly AppDbContext _context;

    public List<Instructor> Instructors { get; set; }

    public IndexModel(AppDbContext context)
    {
      _context = context;
    }

    public void OnGet()
    {
      Instructors = _context.Instructors.Include("CoursesTaught").ToList();
    }

    public void OnPost()
    {
      
    }
  }
}