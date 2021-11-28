﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nedelcu_Mircea_Alin_lab8.Data;
using Nedelcu_Mircea_Alin_lab8.Models;

namespace Nedelcu_Mircea_Alin_lab8.Pages.Publishers
{
    public class DeleteModel : PageModel
    {
        private readonly Nedelcu_Mircea_Alin_lab8.Data.Nedelcu_Mircea_Alin_lab8Context _context;

        public DeleteModel(Nedelcu_Mircea_Alin_lab8.Data.Nedelcu_Mircea_Alin_lab8Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FindAsync(id);

            if (Publisher != null)
            {
                _context.Publisher.Remove(Publisher);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
