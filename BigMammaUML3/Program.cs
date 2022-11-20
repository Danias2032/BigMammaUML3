
using BigMammaUML3;
using System.Linq.Expressions;

// Daniel Hass 

IMenuCatalog menuCatalog = new MenuCatalog();

Console.WriteLine($"Test af Metoder");
Console.WriteLine($"Før add af Pizza {menuCatalog.Count}");
Pizza p1 = new Pizza(1, "Magarita", "Tomato & Cheese", 75.0, MenuType.Pizza, false, true, true);
Console.WriteLine(p1.PrintInfo());

Pasta pa1 = new Pasta(2, "Pasta", "It is Pasta", 55.0, MenuType.Pasta, true, true, false);
Pasta pa2 = new Pasta(5, "Posta", "Pasta m. Ost", 65.0, MenuType.Pasta, false, true, true);
Console.WriteLine(pa1.PrintInfo());
Console.WriteLine(pa2.PrintInfo());

Beverage b1 = new Beverage(4, "Beer", "It is Beer", 55.0, MenuType.AlcoholicDrink, true, true, true);
Console.WriteLine(b1.PrintInfo());
Beverage b2 = new Beverage(3, "Pepsi Max", "Good ol' Pepsi", 25.0, MenuType.SoftDrink, true, false, false);
Console.WriteLine(b2.PrintInfo());

menuCatalog.Add(p1);
menuCatalog.Add(pa1);
menuCatalog.Add(pa2);
menuCatalog.Add(b1);
menuCatalog.Add(b2);
Console.WriteLine($"Efter add af Pizza {menuCatalog.Count}");
Console.WriteLine();

Console.WriteLine($"Test af Print PizzaMenu-metoden");
menuCatalog.PrintPizzasMenu();
Console.WriteLine();

Console.WriteLine($"Test af Search-metoden");
IMenuItem i1 = menuCatalog.Search(3);
Console.WriteLine(i1.PrintInfo());
Console.WriteLine();

Console.WriteLine($"Test af Update-Metoden: Før Update");
menuCatalog.PrintPizzasMenu();
Console.WriteLine();
Console.WriteLine($"Test af Update-Metoden: Efter Update");
Pizza theMenuItem = new Pizza(1, "MAGARITA", "Tomato & Cheese", 75.0, MenuType.Pizza, false, true, true);
menuCatalog.Update(1, theMenuItem);
menuCatalog.PrintPizzasMenu();
Console.WriteLine();

Console.WriteLine($"Test af Item = Vegan-Metoden");
List<IMenuItem> veganItem = menuCatalog.FindAllVegan(MenuType.Pasta);
foreach (IMenuItem veganItems in veganItem)
{
    Console.WriteLine(veganItems.PrintInfo());
}
Console.WriteLine();

Console.WriteLine($"Test af Item = Organic-Metoden");
List<IMenuItem> organicItem = menuCatalog.FindAllOrganic(MenuType.Pasta);
foreach (IMenuItem organicItems in organicItem)
{
    Console.WriteLine(organicItems.PrintInfo());
}
Console.WriteLine();

Console.WriteLine($"Test af MostExpensiveItem");
IMenuItem m1 = menuCatalog.MostExpensiveMenuItem();
Console.WriteLine(m1.PrintInfo());
Console.WriteLine();

Console.WriteLine($"Test af Exceptions");
try
{
    menuCatalog.Add(p1);



}
catch (MenuItemNumberExist min)
{ 
    Console.WriteLine("" + min.Message);    
}
catch (Exception ex)
{
    Console.WriteLine("Generel exception" + ex.Message);
}