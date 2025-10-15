using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Page.Instructors
{
  public class CreateModel : PageModel
  {
    private readonly AppDbContext _context;

    [BindProperty]
    public Instructor Instructor { get; set; }

    public CreateModel(AppDbContext context)
    {
      _context = context;
    }

    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {
      if (!ModelState.IsValid)
        return Page();

      _context.Instructors.Add(Instructor);
      _context.SaveChanges();

      return RedirectToPage("/Instructors/Index");
    }
  }
}
