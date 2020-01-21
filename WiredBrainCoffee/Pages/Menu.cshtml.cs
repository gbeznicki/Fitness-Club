using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class MenuModel : PageModel
    {
        public List<MenuItem> MenuItems { get; set; }
        private IMenuService menuService;
        public void OnGet()
        {
            menuService = new MenuService();
            MenuItems = menuService.GetMenuItems();
        }
    }
}
