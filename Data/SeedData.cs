namespace BlazingPizza.Data;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext context)
    {

        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial
            {
                Id = 1,
                Name = "Classic Margherita",
                Description = "The timeless classic with fresh tomatoes, mozzarella, and basil.",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/margherita.jpg"
            },
            new PizzaSpecial
            {
                Id = 2,
                Name = "Pepperoni Feast",
                Description = "Loaded with pepperoni and extra cheese.",
                BasePrice = 12.99m,
                ImageUrl = "img/pizzas/pepperoni.jpg"
            },
            new PizzaSpecial
            {
                Id = 3,
                Name = "Meaty Extravaganza",
                Description = "A hearty mix of bacon, sausage, and pepperoni.",
                BasePrice = 14.99m,
                ImageUrl = "img/pizzas/meaty.jpg"
            },
            new PizzaSpecial
            {
                Id = 4,
                Name = "Mushroom Lovers",
                Description = "A delightful mix of mushrooms and cheese.",
                BasePrice = 11.99m,
                ImageUrl = "img/pizzas/mushroom.jpg"
            },
            new PizzaSpecial
            {
                Id = 5,
                Name = "Cheese Overload",
                Description = "A blend of mozzarella, cheddar, and parmesan.",
                BasePrice = 10.99m,
                ImageUrl = "img/pizzas/cheese.jpg"
            },
            new PizzaSpecial
            {
                Id = 6,
                Name = "Salad Pizza",
                Description = "A fresh mix of greens on a crispy crust.",
                BasePrice = 9.49m,
                ImageUrl = "img/pizzas/salad.jpg"
            },
            new PizzaSpecial
            {
                Id = 7,
                Name = "British Style",
                Description = "A unique blend of flavors inspired by British cuisine.",
                BasePrice = 13.49m,
                ImageUrl = "img/pizzas/brit.jpg"
            },
            new PizzaSpecial
            {
                Id = 8,
                Name = "Bacon Delight",
                Description = "Crispy bacon with a touch of BBQ sauce.",
                BasePrice = 12.49m,
                ImageUrl = "img/pizzas/bacon.jpg"
            }
        };

        context.Specials.AddRange(specials);
        context.SaveChanges();
    }
}