using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ERPDBContext.Data;
using Users.Models;

namespace Achadinhos.Pages;

public class RegisterModel : PageModel
{
    [BindProperty]
    public required User user { get; set; }

    private readonly ErpDbContext _db;

    public RegisterModel(ErpDbContext db)
    {
        _db = db;
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page(); // Ou qualquer outra resposta adequada
        }

        _db.Users.Add(user);
        _db.SaveChanges();

        return RedirectToPage("Index"); // Ou qualquer outra página
    }
}
