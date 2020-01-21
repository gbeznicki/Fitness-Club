using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }
        public string Message { get; private set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                EmailService.SendEmail(Contact);
                return new RedirectToPageResult("Confirmation", "Contact");
            }
            else
            return Page();
        }

        public IActionResult OnPostSubscribe(string address)
        {
            bool isValid = new EmailAddressAttribute().IsValid(address);
            if (isValid)
            {
                EmailService.SendEmail(address);
                return new RedirectToPageResult("Confirmation", "Subscribe");
            }
            else
            return Page();
        }
    }
}
