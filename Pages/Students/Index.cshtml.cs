using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Page.Students
{
  public class IndexModel : PageModel
  {
    private readonly AppDbContext _context;

    public List<Student> Students { get; set; }

    public IndexModel(AppDbContext context)
    {
      _context = context;
    }

    public void OnGet()
    {
      Students = _context.Students.Include("EnrolledCourses").ToList();
    }

    public void OnPost()
    {
      
    }
  }
}
