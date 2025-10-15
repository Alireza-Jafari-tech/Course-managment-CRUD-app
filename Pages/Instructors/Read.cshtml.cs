using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Page.Instructors
{
  public class ReadModel : PageModel
  {
    private readonly AppDbContext _context;

    public Instructor Instructor { get; set; }

    public ReadModel(AppDbContext context)
    {
      _context = context;
    }

    public IActionResult OnGet(int id)
    {
      Instructor = _context.Instructors.Find(id);

      if (Instructor == null)
        return RedirectToPage("/NotFound");

      return Page();
    }

    public void OnPost()
    {
      
    }
  }
}