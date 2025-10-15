using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Pages.Courses
{
    public class DeleteModel : PageModel
    {
        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }
        private readonly AppDbContext _context;


        [BindProperty]
        public Course Course { get; set; }

        public IActionResult OnGet(int id)
        {
            Course = _context.Courses.Include("Instructor")
                                                            .FirstOrDefault(c => c.Id == id);

            if (Course == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        public IActionResult OnPost()
        {

          if (!ModelState.IsValid)
            return Page();
            
            var course = _context.Courses.Find(Course.Id);

            if (course == null)
                return RedirectToPage("/NotFound");

            _context.Courses.Remove(course);
            _context.SaveChanges();

            return RedirectToPage("/Courses/Index");
        }
    }
}
