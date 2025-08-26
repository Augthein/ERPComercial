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
        //Check if the .cshtml form validations passed
        if (!ModelState.IsValid)
        {
            return Page();
        }

        //Register user after checking for all non form validations
        var registeredUser = _db.Users.FirstOrDefault(u => u.UserName == user.UserName);

        //Check if UserName already exists
        if (registeredUser != null)
        {
            ModelState.AddModelError("user.UserName", "Usuário já cadastrado.");
            return Page();
        }
        //Register if all complains
        else
        {
            _db.Users.Add(user);
            _db.SaveChanges();

            return RedirectToPage("Index");
        }
        
    }
}
