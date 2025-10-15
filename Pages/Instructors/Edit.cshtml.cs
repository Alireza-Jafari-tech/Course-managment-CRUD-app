using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Page.Instructors
{
  public class EditModel : PageModel
  {
    private readonly AppDbContext _context;

    [BindProperty]
    public Instructor Instructor { get; set; }

    public EditModel(AppDbContext context)
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

    public IActionResult OnPost()
    {
      if (!ModelState.IsValid)
        return Page();

        var existingPost = _context.Instructors.Find(Instructor.Id);
        if (existingPost == null)
            return RedirectToPage("/NotFound");

        existingPost.Name = Instructor.Name;
        existingPost.Email = Instructor.Email;
        existingPost.Password = Instructor.Password;

        _context.Attach(existingPost).State = EntityState.Modified;
        _context.SaveChanges();

        return RedirectToPage("/Instructors/Index");
    }
  }
}