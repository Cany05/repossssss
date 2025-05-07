using TaskPizza;
using System;

namespace TestPizza
{
    public class Tests
    {
        [TestFixture]
        public class PizzaTests
        {
            [Test]
            public void Constructor_ShouldInitializeProperties()
            {
                var ingredients = new[] { "Маслины", "Грибы" };
                var pizza = new Pizza("Маргарита", "Классическая пицца", 30, PizzaType.Thin, ingredients, 500);

                Assert.AreEqual("Маргарита", pizza.Name);
                Assert.AreEqual("Классическая пицца", pizza.Description);
                Assert.AreEqual(30, pizza.Diameter);
                Assert.AreEqual(PizzaType.Thin, pizza.Type);
                Assert.AreEqual(ingredients, pizza.AdditionalIngredients);
                Assert.AreEqual(500, pizza.Price);
            }

            [Test]
            public void GetInfo_ShouldReturnCorrectInfo()
            {
                var ingredients = new[] { "Маслины", "Грибы" };
                var pizza = new Pizza("Маргарита", "Классическая пицца", 30, PizzaType.Thin, ingredients, 500);

                var expectedInfo = "Пицца: Маргарита, Тип: Thin, Диаметр: 30 см, Цена: 500,00 ?, Описание: Классическая пицца, Доп. ингредиенты: Маслины, Грибы";
                Assert.AreEqual(expectedInfo, pizza.GetInfo());
            }
            [Test]
            public void Diameter_SetNegativeValue_ShouldThrowArgumentOutOfRangeException()
            {
                var pizza = new Pizza("Маргарита", "Классическая пицца", 30, PizzaType.Thin, new[] { "Маслины" }, 500);

                Assert.Throws<ArgumentOutOfRangeException>(() => pizza.Diameter = -5);
            }

            [Test]
            public void Price_SetNegativeValue_ShouldThrowArgumentOutOfRangeException()
            {
                var pizza = new Pizza("Маргарита", "Классическая пицца", 30, PizzaType.Thin, new[] { "Маслины" }, 500);

                Assert.Throws<ArgumentOutOfRangeException>(() => pizza.Price = -100);
            }

            [Test]
            public void Description_SetNull_ShouldThrowArgumentNullException()
            {
                var pizza = new Pizza("Маргарита", "Классическая пицца", 30, PizzaType.Thin, new[] { "Маслины" }, 500);

                Assert.Throws<ArgumentNullException>(() => pizza.Description = null);
            }

            [Test]
            public void AdditionalIngredients_SetNull_ShouldThrowArgumentNullException()
            {
                var pizza = new Pizza("Маргарита", "Классическая пицца", 30, PizzaType.Thin, new[] { "Маслины" }, 500);

                Assert.Throws<ArgumentNullException>(() => pizza.AdditionalIngredients = null);
            }
            [Test]
            public void Drink_ShouldReturnCorrectInfo()
            {
                string name = "Coca-Cola";
                string description = "Освежающий напиток";
                string type = "Холодный";
                int volume = 500;
                decimal price = 1.99m;

                var drink = new Drink(name, description, type, volume, price);

                Assert.AreEqual(name, drink.Name);
                Assert.AreEqual(description, drink.Description);
                Assert.AreEqual(type, drink.Type);
                Assert.AreEqual(volume, drink.Volume);
                Assert.AreEqual(price, drink.Price);
            }

            [Test]
            public void Drink_SetNegativeValue_ShouldThrowArgumentOutOfRangeException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => new Drink("Drink", "Description", "Холодный", -1, 10));
            }

            [Test]
            public void Drink_SetNull_ShouldThrowArgumentNullException()
            {
                Assert.Throws<ArgumentNullException>(() => new Drink("Drink", "Description", null, 500, 10));
            }

            [Test]
            public void Snack_ShouldReturnCorrectInfo()
            {
                string name = "Куриные крылышки";
                string description = "Вкусные куриные крылышки с соусом";
                int weight = 300;
                decimal price = 5.99m;

                var snack = new Snack(name, description, weight, price);

                Assert.AreEqual(name, snack.Name);
                Assert.AreEqual(description, snack.Description);
                Assert.AreEqual(weight, snack.Weight);
                Assert.AreEqual(price, snack.Price);
            }

            [Test]
            public void Snack_SetNegativeValue_ShouldThrowArgumentOutOfRangeException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => new Snack("Snack", "Description", -10, 10));
            }
        }
    }
}