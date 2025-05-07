using NUnit.Framework;
using TaskPizza;
namespace TestOrder
{
    public class OrderTests
    {
        [Test]
        public void AddPizza_ShouldAddPizzaToOrder()
        {
            var order = new Order("Ivanov Ivan", "Moscow", "123456789");
            var pizza = new Pizza("Margherita", "Томаты, моцарелла", 30, PizzaType.Thin, new string[] { }, 500);
            order.AddPizza(pizza);

            Assert.AreEqual(1, order.Count()); 
        }

        [Test]
        public void SortPizzas_ShouldSortPizzasByNameAndDiameter()
        {
            var order = new Order("Ivanov Ivan", "Moscow", "123456789");
            var pizza1 = new Pizza("Margherita", "Томаты, моцарелла", 30, PizzaType.Thin, new string[] { }, 500);
            var pizza2 = new Pizza("Pepperoni", "Пепперони, моцарелла", 40, PizzaType.Thin, new string[] { }, 600);
            var pizza3 = new Pizza("Hawaiian", "Ветчина, ананасы", 35, PizzaType.Thin, new string[] { }, 550);

            order.AddPizza(pizza1);
            order.AddPizza(pizza2);
            order.AddPizza(pizza3);

            order.SortPizzas(); 

            var sortedPizzas = order.GetPizzas();

            Assert.AreEqual("Hawaiian", sortedPizzas[0].Name);
            Assert.AreEqual("Margherita", sortedPizzas[1].Name);
            Assert.AreEqual("Pepperoni", sortedPizzas[2].Name);
        }
    }
}