using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskPizza
{
    public enum PizzaType
    {
        Thick,
        Thin,
        Closed
    }

    public class Pizza
    {

        private readonly string _name;
        private string _description;
        private double _diameter;
        private PizzaType _type;
        private string[] _additionalIngredients;
        private decimal _price;


        public Pizza(string name, string description, double diameter, PizzaType type, string[] additionalIngredients, decimal price)
        {
            _name = name;
            Description = description;
            Diameter = diameter;
            Type = type;
            AdditionalIngredients = additionalIngredients;
            Price = price;
        }


        public string Name => _name;
        public string Description
        {
            get => _description;
            set => _description = value ?? throw new ArgumentNullException(nameof(value), "Описание не может быть null");
        }

        public double Diameter
        {
            get => _diameter;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Диаметр должен быть положительным");
                _diameter = value;
            }
        }

        public PizzaType Type
        {
            get => _type;
            set => _type = value;
        }

        public string[] AdditionalIngredients
        {
            get => _additionalIngredients;
            set => _additionalIngredients = value ?? throw new ArgumentNullException(nameof(value), "Дополнительные ингредиенты не могут быть null");
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Цена не может быть отрицательной");
                _price = value;
            }
        }

        public string GetInfo()
        {
            return $"Пицца: {Name}, Тип: {Type}, Диаметр: {Diameter} см, Цена: {Price:C}, Описание: {Description}, Доп. ингредиенты: {string.Join(", ", AdditionalIngredients)}";
        }
    }
}
