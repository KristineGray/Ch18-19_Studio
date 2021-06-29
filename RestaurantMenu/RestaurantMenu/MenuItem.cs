using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public DateTime Created = DateTime.Now;
        public bool isNew = true;

        public void PrintMenuItem()
        {
            if (this.isNew == true)
                Console.WriteLine($"*NEW* from {this.Created}");
            Console.WriteLine($"{this.Name}..........${this.Price}\n\tDescription: {this.Description}\n");
        }
    }
}
