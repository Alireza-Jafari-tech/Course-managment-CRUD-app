using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Page.Students
{
  public class CreateModel : PageModel
  {
    private readonly AppDbContext _context;

    [BindProperty]
    public Student Student { get; set; }

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

      _context.Students.Add(Student);
      _context.SaveChanges();

      return RedirectToPage("/Index");
    }
  }
}
