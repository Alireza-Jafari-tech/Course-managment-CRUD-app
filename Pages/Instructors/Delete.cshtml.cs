using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Pages.Instructors
{
    public class DeleteModel : PageModel
    {
        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }
        private readonly AppDbContext _context;


        [BindProperty]
        public Instructor Instructor { get; set; }

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
            
            var instructor = _context.Instructors.Find(Instructor.Id);

            if (instructor == null)
                return RedirectToPage("/NotFound");

            _context.Instructors.Remove(instructor);
            _context.SaveChanges();

            return RedirectToPage("/Instructors/Index");
        }
    }
}
