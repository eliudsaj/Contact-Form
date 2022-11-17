using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace saj.Pages
{
    public class ContactModel : PageModel
    {
        public bool hasData = false;
        public string Name = "";
        public string Email = "";
        public string Message = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = true;
            Name = Request.Form["Name"];
            Email = Request.Form["Email"];
            Message = Request.Form["Message"];

        }
    }
}
