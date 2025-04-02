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

    public abstract class Dish
    {
        public string Name { get; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        protected Dish(string name, string description, decimal price)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Название не может быть null");
            Description = description ?? throw new ArgumentNullException(nameof(description), "Описание не может быть null");
            Price = price < 0 ? throw new ArgumentOutOfRangeException(nameof(price), "Цена не может быть отрицательной") : price;
        }

        public abstract string GetInfo();
    }

    public class Pizza : Dish
    {
        public double _diameter;
        public PizzaType Type { get; }
        public string[] AdditionalIngredients { get; set; }

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

        public Pizza(string name, string description, double diameter, PizzaType type, string[] additionalIngredients, decimal price)
            : base(name, description, price)
        {
            Diameter = diameter;
            Type = type;
            AdditionalIngredients = additionalIngredients ?? throw new ArgumentNullException(nameof(additionalIngredients), "Дополнительные ингредиенты не могут быть null");
        }

        public override string GetInfo()
        {
            return $"Пицца: {Name}, Тип: {Type}, Диаметр: {Diameter} см, Цена: {Price:C}, Описание: {Description}, Доп. ингредиенты: {string.Join(", ", AdditionalIngredients)}";
        }
    }

    public class Drink : Dish
    {
        public string Type { get; } 
        public int Volume { get; } 

        public Drink(string name, string description, string type, int volume, decimal price)
            : base(name, description, price)
        {
            Type = type ?? throw new ArgumentNullException(nameof(type), "Тип напитка не может быть null");
            Volume = volume <= 0 ? throw new ArgumentOutOfRangeException(nameof(volume), "Объем должен быть положительным") : volume;
        }

        public override string GetInfo()
        {
            return $"Напиток: {Name}, Тип: {Type}, Объем: {Volume} мл, Цена: {Price:C}, Описание: {Description}";
        }
    }

    public class Snack : Dish
    {
        public int Weight { get; }

        public Snack(string name, string description, int weight, decimal price)
            : base(name, description, price)
        {
            Weight = weight <= 0 ? throw new ArgumentOutOfRangeException(nameof(weight), "Вес должен быть положительным") : weight;
        }

        public override string GetInfo()
        {
            return $"Закуска: {Name}, Вес: {Weight} г, Цена: {Price:C}, Описание: {Description}";
        }
    }
}