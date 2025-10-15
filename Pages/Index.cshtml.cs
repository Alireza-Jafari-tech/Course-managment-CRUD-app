using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using project.Data;
using project.Model;

namespace project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Course> Courses { get; set; }

        public void OnGet()
        {
            Courses = _context.Courses
                .Include(c => c.Instructor)
                .Include("Comments")
                .Include("Students")
                .ToList();
        }
    }
}
