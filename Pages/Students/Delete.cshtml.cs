using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Model;

namespace project.Pages.Students
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; }

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
            
            var student = _context.Students
                                            .FirstOrDefault(s => s.Id == Student.Id);

            if (student == null)
                return RedirectToPage("/NotFound");

            _context.Students.Remove(student);
            _context.SaveChanges();

            return RedirectToPage("/Students/Index");
        }
    }
}
