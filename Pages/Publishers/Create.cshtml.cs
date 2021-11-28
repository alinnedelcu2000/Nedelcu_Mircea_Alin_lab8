using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nedelcu_Mircea_Alin_lab8.Data;
using Nedelcu_Mircea_Alin_lab8.Models;

namespace Nedelcu_Mircea_Alin_lab8.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Nedelcu_Mircea_Alin_lab8.Data.Nedelcu_Mircea_Alin_lab8Context _context;

        public CreateModel(Nedelcu_Mircea_Alin_lab8.Data.Nedelcu_Mircea_Alin_lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
