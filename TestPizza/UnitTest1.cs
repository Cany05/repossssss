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
        }
    }
}