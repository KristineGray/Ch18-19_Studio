using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            MenuItem itemOne = new MenuItem();
            itemOne.Name = "Rice";
            itemOne.Description = "A bowl of rice";
            itemOne.Price = 5.99;
            itemOne.Category = "Appetizer";
            itemOne.isNew = false;

            MenuItem itemTwo = new MenuItem();
            itemTwo.Name = "Breadsticks";
            itemTwo.Description = "A bowl of breadsticks";
            itemTwo.Price = 2.99;
            itemTwo.Category = "Appetizer";
            
            MenuItem itemThree = new MenuItem();
            itemThree.Name = "Chicken Caesar Salad";
            itemThree.Description = "Sliced grilled chicken served on a bed of various greens";
            itemThree.Price = 8.99;
            itemThree.Category = "Main Course";
            itemThree.isNew = false;
            
            MenuItem itemFour = new MenuItem();
            itemFour.Name = "Chicken Adobo";
            itemFour.Description = "A bowl chicken thighs marinated in soy sauce and vinegar; served on top of jasmine rice";
            itemFour.Price = 9.99;
            itemFour.Category = "Main Course";
            itemFour.isNew = false;
            
            MenuItem itemFive = new MenuItem();
            itemFive.Name = "Ice Cream";
            itemFive.Description = "A scoop of vanilla, chocolate, or strawberry ice cream";
            itemFive.Price = 1.99;
            itemFive.Category = "Dessert";
            
            MenuItem itemSix = new MenuItem();
            itemSix.Name = "Apple Pie";
            itemSix.Description = "A slice of fresh apple pie";
            itemSix.Price = 2.99;
            itemSix.Category = "Dessert";

            menu.AddItem(itemOne);
            menu.AddItem(itemTwo);
            menu.AddItem(itemThree);
            menu.AddItem(itemFour);
            menu.AddItem(itemFive);
            menu.AddItem(itemSix);
            menu.LastUpdated = DateTime.Now;

            Console.WriteLine($"This is the entire menu using the PrintMenu method from the Manu class.\n\n");
            menu.PrintMenu(); 
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"This is the new menu after itemTwo {itemTwo.Name} has been removed using the RemoveItem method from the Menu class.");
            Console.WriteLine($"For reference, the previous update was {menu.LastUpdated}.\n\n");
            menu.RemoveItem(itemTwo);
            menu.LastUpdated = DateTime.Now;
            menu.PrintMenu(); 
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"This is just itemFour {itemFour.Name} using the PrintMenuItem method from the MenuItem class.\n\n");
            itemFour.PrintMenuItem();     
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Comparing Prices Test One: Expected Result: FALSE");
            menu.ComparePrices(itemOne, itemTwo);
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Comparing Prices Test Two: Expected Result: TRUE");
            menu.ComparePrices(itemSix, itemTwo);
            Console.ReadKey();
        }
    }
}
