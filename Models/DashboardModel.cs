using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SecuredHub.Models
{

public class DashboardModel : PageModel
{
    [BindProperty]
    public string UserName { get; set; }

    public void OnGet()
    {
        // Get the logged-in user's name from the session or database
        UserName = HttpContext.Session.GetString("UserName");
    }
}
}