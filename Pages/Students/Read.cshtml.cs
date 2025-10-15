using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Page.Students
{
  public class ReadModel : PageModel
  {
    private readonly AppDbContext _context;
    public Student Student { get; set; }

    public ReadModel(AppDbContext context)
    {
      _context = context;
    }

    public IActionResult OnGet(int id)
    {
      Student = _context.Students.Find(id);

      if (Student == null)
        return RedirectToPage("/NotFound");

      return Page();
    }

    public void OnPost()
    {
      
    }
  }
}