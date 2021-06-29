using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class Menu
    {
        public string Name = "Restaurant Menu";
        public DateTime LastUpdated { get; set; }

        //public List<MenuItem> appetizers = new List<MenuItem>();
        //public List<MenuItem> mainCourses = new List<MenuItem>();
        //public List<MenuItem> desserts = new List<MenuItem>();
        List<MenuItem> items = new List<MenuItem>();

        public void AddItem(MenuItem item)
        {
            items.Add(item);
        }
        
        public void RemoveItem(MenuItem item)
        {
            items.Remove(item);
        }

        /*
        public void PrintMenuItem(MenuItem item)
        {
            item.PrintMenuItem();
        }
        */

        public void PrintMenu()
        {
            Console.WriteLine($"{this.Name.ToUpper()}\n");
            foreach (MenuItem item in items)
                item.PrintMenuItem();
            Console.WriteLine($"\n\n\nMenu Last Updated: {this.LastUpdated}");
        }

        public void ComparePrices(MenuItem itemOne, MenuItem itemTwo)
        {
            if (itemOne.Price == itemTwo.Price)
            {
                Console.WriteLine($"\n{itemOne.Name} has the same price as {itemTwo.Name} of ${itemOne.Price}");
            }
            else
            {
                Console.WriteLine($"\n{itemOne.Name} with a price of ${itemOne.Price} does not have the same price as {itemTwo.Name} which is ${itemTwo.Price}");
            }

        }
    }
}
