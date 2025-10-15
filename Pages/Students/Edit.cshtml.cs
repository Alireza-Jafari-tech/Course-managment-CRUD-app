using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Page.Students
{
  public class EditModel : PageModel
  {
    private readonly AppDbContext _context;

    [BindProperty]
    public Student Student { get; set; }

    public EditModel(AppDbContext context)
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

    public IActionResult OnPost()
    {
      if (!ModelState.IsValid)
        return Page();

        var existingPost = _context.Students.Find(Student.Id);
        if (existingPost == null)
            return RedirectToPage("/NotFound");

        existingPost.Name = Student.Name;
        existingPost.Email = Student.Email;
        existingPost.Password = Student.Password;

        _context.Attach(existingPost).State = EntityState.Modified;
        _context.SaveChanges();

        return RedirectToPage("/Students/Index");
    }
  }
}