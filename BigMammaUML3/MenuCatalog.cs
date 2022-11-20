using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BigMammaUML3
{
    public class MenuCatalog : IMenuCatalog
    {
        private List<IMenuItem> _items;
        public List<IMenuItem> Items
        {
            get { return _items; }
        }
        public MenuCatalog()
        {
            _items = new List<IMenuItem>();
        }
        public int Count
        {
            get { return _items.Count; }
        }
        // Der hvor man kalder denne metode skal man catche Exception
        // Det vil være i program.cs
        public void Add(IMenuItem aMenuItem)
        {
            /* Hvis MenuItem objektet allerede eksisterer
             * da kast Exception
             * Throw new MenuItemExcepton("Fejlmeddelelse") 
             * else del ellers throw'er den Exceptionen 
             * når bare objektet optræder 1. gang. */
            
            if (Search(aMenuItem.Number) == null)
                _items.Add(aMenuItem);
            else
                throw new MenuItemNumberExist("Menu objektet eksisterer allerede.");
        }
        public IMenuItem Search(int number)
        {
            foreach (IMenuItem item in _items)
            {
                if (item.Number == number)
                    return item;
            }
            return null;
        }
        public void Delete(int number)
        {
            IMenuItem item = Search(number);
            _items.Remove(item);
        }
        public void PrintPizzasMenu()
        {
            foreach (IMenuItem item in _items)
            {
                if (item.Type == MenuType.Pizza)
                    Console.WriteLine(item.PrintInfo());
            }
        }
        public void PrintBeveragesMenu()
        {
            foreach (IMenuItem item in _items)
            {
                if (item.Type == MenuType.SoftDrink)
                    Console.WriteLine(item.PrintInfo());
                else if (item.Type == MenuType.AlcoholicDrink)
                    Console.WriteLine(item.PrintInfo());
            }
        }
        public void PrintToppingsMenu()
        {
            foreach (IMenuItem item in _items)
            {
                if (item.Type == MenuType.Topping)
                    Console.WriteLine(item.PrintInfo());
            }
        }
        public void Update(int number, IMenuItem theMenuItem)
        {
            int i = 0;
            while (i < _items.Count)
            {
                if (_items[i].Number == number)
                {
                    _items[i] = theMenuItem;
                    break;
                }
                i++;
            }
        }
        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> veganItems = new List<IMenuItem>();

            foreach (IMenuItem item in _items)
            {
                if (item.Type == type && item.IsVegan == true)
                    veganItems.Add(item);
            }
            return veganItems;
            //lav en ny menuliste til at retunere
            //løbe _items igennem
            //Hvis den aktuelle items type er = menutype
            //og er Vegansk
            //så tilføj til menuliste
            //return liste
        }
        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> organicItems = new List<IMenuItem>();

            foreach (IMenuItem item in _items)
            {
                if (item.Type == type && item.IsOrganic == true)
                    organicItems.Add(item);
            }
            return organicItems;
        }
        public IMenuItem MostExpensiveMenuItem()
            // Lav som: For-Loop & While-Loop
        {
            IMenuItem MostExpensiveMenuItem = _items[0];
            foreach (IMenuItem item in _items)
            {
                if (MostExpensiveMenuItem.Price < item.Price)
                {
                    MostExpensiveMenuItem = item;
                }
            }
            return MostExpensiveMenuItem;
        }
    }
}
