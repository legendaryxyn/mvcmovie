using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Model;
using MvcMovie.Models;

namespace MvcMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MvcMovie.Models.MvcMovieContext _context;

        public IndexModel(MvcMovie.Models.MvcMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
