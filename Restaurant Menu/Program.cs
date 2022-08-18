using System;

namespace Restaurant_Menu
{
    class Program 
    {
        static void Main(string[] args)
        { 
            var menu = new Menu();
            menu.AddMenuItem(new MenuItem("Loco Moco", 8.99, "SPAM, hamburger patty, and egg served over a bed of white rice topped with gravy with a side of potato mac salad.", "Main Course", false));
            menu.AddMenuItem(new MenuItem("SPAM Musubi", 2.99, "Seaweed wrapped SPAM slice and rice.", "Appetizer", false));
            menu.AddMenuItem(new MenuItem("Potato Mac Salad", 4.99, "1 lb of Potato Mac Salad", "Appetizer", false));
            menu.AddMenuItem(new MenuItem("Pork Lau Lau", 10.99, "Pork wrapped in ti leaf. Served with a side of rice and potato mac salad.", "Main Course", false));
            menu.AddMenuItem(new MenuItem("Huli Huli Chicken", 12.99, "Smoked sweet chicken. Served with a side of rice and potato mac salad.", "Main Course", false));
            menu.AddMenuItem(new MenuItem("Haupia Pie", 4.99, "A traditional Hawiian dessert made from thickened coconut milk and chocolate and layered into a pre-baked pie crust and topped with whipped cream.", "Dessert", false));
            menu.AddMenuItem(new MenuItem("Poi Mochi", 8.99, "Crispy golden brown little dough balls made with poi, mochiko flour, coconut milk, and sugar", "Dessert", true));
           
            Console.WriteLine(menu);

            Console.ReadKey();
        }
    }
}