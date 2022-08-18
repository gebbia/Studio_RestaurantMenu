using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Menu
{
    public class MenuItem
    {

        //Each menu item has a price, description, and category

        //It should be possible to display whether a menu item is new or not

        

    public string Item { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; } //(appetizer, main course, or dessert)
    public bool NewItem { get; set; }
    
    public MenuItem(string item, double price, string description, string category, bool newItem)
        {
            Item = item;
            Price = price;
            Description = description;
            Category = category;
            NewItem = newItem;
        }

        public bool Equals(MenuItem isNew)
        {
            return this.Item == isNew.Item;
        }

    }
}
