using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Page.Courses
{
  public class CreateModel : PageModel
  {
    private readonly AppDbContext _context;

    [BindProperty]
    public Course Course { get; set; }
    public List<SelectListItem> InstructorList { get; set; }

    public CreateModel(AppDbContext context)
    {
      _context = context;
    }

    public void OnGet()
    {
      InstructorList = _context.Instructors
        .Select(i => new SelectListItem
        {
          Value = i.Id.ToString(),
          Text = i.Name
        })
        .ToList();
    }

    public IActionResult OnPost()
    {
      if (!ModelState.IsValid)
        return Page();

      _context.Courses.Add(Course);
      _context.SaveChanges();

      return RedirectToPage("Index");
    }
  }
}
