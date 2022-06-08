using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Cannon;
using MyScriptureJournal.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyScriptureJournal.Pages.Journals
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get; set; } = default;
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }

        
        //[BindProperty(SupportsGet = true)]
        //public string ScriptureNotes { get; set; }

        public async Task OnGetAsync()
        {// Use LINQ to get list of books.
            IQueryable<string> bookQuery = from s in _context.Scripture
                           orderby s.Book
                           select s.Book;

            var journals = from S in _context.Scripture
                           select S;

            if (!string.IsNullOrEmpty(SearchString))
            {
                journals = journals.Where(s => s.Book.Contains(SearchString));

            }

            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                journals = journals.Where(x => x.Book == ScriptureBook);
            }
            ViewData["Books"] = new SelectList(await bookQuery.Distinct().ToListAsync());
            Scripture = await journals.ToListAsync();
            

        }


    }

    }

