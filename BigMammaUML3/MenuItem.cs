using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public abstract class MenuItem : IMenuItem
    {
        private int _number;
        private string _name;
        private string _description;
        private double _price;
        private bool _isVegan;
        private bool _isOrganic;

        public int Number
        {
            get { return _number; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public MenuType Type { get; set; }
        public bool IsVegan
        {
            get { return _isVegan; }
            set { _isVegan = value; }
        }
        public bool IsOrganic
        {
            get { return _isOrganic; }
            set { _isOrganic = value; }
        }
        public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic)
        {
            _number = number;
            _name = name;
            _description = description;
            _price = price;
            Type = type;
            _isVegan = isVegan;
            _isOrganic = isOrganic;
        }

        public virtual string PrintInfo()
        { return $"Number {Number}, Name {Name}, Description: {Description}, Price {Price}, Type {Type} isVegan {IsVegan}, isOrganic {IsOrganic}, "; }
    }
}
