using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Menu
{
    public class Menu
    {
        //The menu consists of several menu items
        //The app should know when the menu was last updated,
        //give access to restaurant owner to display their current menu
        //and edit it through an admin panel
        public List<MenuItem> MenuItems { get; }
        public DateTime LastUpdate { get; set; }
   

    public Menu(DateTime updatedTime, List<MenuItem> menuItems)
        {
            MenuItems = menuItems;
            LastUpdate = updatedTime;
        }

        public Menu(List<MenuItem> menuItems): this(new DateTime(), menuItems) { }
       

        public void AddMenuItem(MenuItem menuItem)
        {
            if (!this.MenuItems.Contains(menuItem))
            {
                this.MenuItems.Add(menuItem);
                this.LastUpdate = DateTime.Now; 
            }
        }
    }
}

