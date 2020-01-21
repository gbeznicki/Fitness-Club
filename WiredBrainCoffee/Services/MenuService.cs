using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Services
{
    public class MenuService : IMenuService
    {
        public List<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>()
            {
                new MenuItem()
                {
                    Id = 1,
                    Slug = "peanut-butter-rice-crispy-treats",
                    Name = "Peanut Butter Rice Crispy Treats",
                    Summary = "Peanut butter rice crispy treats without marshmallows that use whole, real ingredients and that the whole family will love.",
                    Description = " ",
                    ImageFile = "crispy.jpg"
                },
                new MenuItem()
                {
                    Id = 2,
                    Slug = "chicken-caprese",
                    Name = "Chicken Caprese",
                    Summary = "Let me break it down for you: mozzarella + tomato + basil + chicken breast = amazingness.",
                    Description = " ",
                    ImageFile = "Caprese-Stuffed-Chicken.jpg"
                },
                new MenuItem()
                {
                    Id = 3,
                    Slug = "granola-with-nuts",
                    Name = "Granola with Nuts",
                    Summary = "It's not flashy, but it sure is healthy.  Perfect for when you need the calories, but not the guilt.",
                    Description = " ",
                    ImageFile = "granola.png"
                },
                new MenuItem()
                {
                    Id = 4,
                    Slug = "protein-shakes",
                    Name = "Protein Shakes",
                    Summary = "Pack in the protein with one of our delicious protein shakes! We make them with frozen fruit/ice, a protein source such as protein powder, and a liquid.",
                    Description = " ",
                    ImageFile = "shakes.jpg"
                },
                new MenuItem()
                {
                    Id = 5,
                    Slug = "fresh-bagels",
                    Name = "Fresh Bagels",
                    Summary = "They're just as round as donuts, but far more healthy! Freshly made every morning before sunrise.",
                    Description = " ",
                    ImageFile = "bagel.png"
                },
                new MenuItem()
                {
                    Id = 6,
                    Slug = "fresh-fruit",
                    Name = "Fresh Fruit",
                    Summary = "We've got strawberries, blueberries, apples, bananas - we could list them all, but we'd prefer you come take a look!",
                    Description = " ",
                    ImageFile = "strawberries.png"
                }
            };
        }
    }
}
