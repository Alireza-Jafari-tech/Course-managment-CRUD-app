using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Pages.Courses
{
    public class ReadModel : PageModel
    {
        private readonly AppDbContext _context;

        // [BindProperty]
        public Course Course { get; set; }
        [BindProperty]
        public Comment NewComment { get; set; }
        // [BindProperty]
        public Student Student { get; set; }

        public ReadModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
            // Course = _context.Courses.Find(id);
            Course = _context.Courses
                                      .Include("Comments")
                                      .Include("Instructor")
                                      .FirstOrDefault(c => c.Id == id);

            if (Course == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        // public IActionResult OnPostRegister()
        // {
        //     // Only validate the NewComment property
        //     ModelState.ClearValidationState(nameof(Student));
        //     if (!TryValidateModel(Student, nameof(Student)))
        //     {
        //         return Page();
        //     }
        //     return RedirectToPage("/Index");
        // }

        public IActionResult OnPostComment(int id)
        {
            NewComment.CourseId = id;

            // Only validate the NewComment property
            ModelState.ClearValidationState(nameof(NewComment));
            if (!TryValidateModel(NewComment, nameof(NewComment)))
            {
                // reload the course to show the same page again
                Course = _context.Courses
                    .Include(c => c.Comments)
                    .FirstOrDefault(c => c.Id == id);
                return Page();
            }

            _context.Comments.Add(NewComment);
            _context.SaveChanges();

            // redirect back to the same course details page
            return RedirectToPage("/Courses/Read", new { id });
        }
    }
}