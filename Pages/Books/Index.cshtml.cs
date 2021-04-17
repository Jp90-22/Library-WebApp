using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBookContext _context;

        //vars for search
        [BindProperty(SupportsGet = true)]
        public string TitleSearch {get; set;}

        public IndexModel(RazorPagesBookContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            //Search algorithm
            var book = from m in _context.Book select m;
            if(!string.IsNullOrEmpty(TitleSearch))
            {
                book = book.Where(s => s.Title.Contains(TitleSearch));
            }

            Book = await book.ToListAsync();
        }
    }
}
