using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Page.Courses
{
  public class EditModel : PageModel
  {
    private readonly AppDbContext _context;

    [BindProperty]
    public Course Course { get; set; }
    public IEnumerable<SelectListItem> InstructorList { get; set; }
    
    

    public EditModel(AppDbContext context)
    {
      _context = context;
    }

    public IActionResult OnGet(int id)
    {
      Course = _context.Courses.Find(id);

      if (Course == null)
        return RedirectToPage("/NotFound");

        InstructorList = _context.Instructors
        .Select(i => new SelectListItem
        {
          Value = i.Id.ToString(),
          Text = i.Name
        })
        .ToList();

      return Page();
    }

    public IActionResult OnPost()
    {
      if (!ModelState.IsValid)
        return Page();

        var existingPost = _context.Courses.Find(Course.Id);
        if (existingPost == null)
            return RedirectToPage("/NotFound");

        existingPost.Title = Course.Title;
        existingPost.Exerpt = Course.Exerpt;
        existingPost.Description = Course.Description;
        existingPost.ImageUrl = Course.ImageUrl;
        existingPost.InstructorId = Course.InstructorId;

        _context.Attach(existingPost).State = EntityState.Modified;
        _context.SaveChanges();

        return RedirectToPage("/Courses/Index");
    }
  }
}