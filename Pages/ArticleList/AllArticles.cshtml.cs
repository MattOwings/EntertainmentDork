using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntertainmentDork.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntertainmentDork.Pages.ArticleList
{
    public class AllArticlesModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public AllArticlesModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Article> Articles { get; set; }
        public async Task OnGet()
        {
            Articles = await _db.Article.ToListAsync();
        }
    }
}
