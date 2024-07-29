using IndexedClasses_Ice1;

namespace IndexedClasses_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFoodItem()
        {
            Menu menu = new Menu("Burger", 50.00);
            Assert.AreEqual(menu[0], "Burger");
        }

        [TestMethod]
        public void TestPrice()
        {
            Menu menu = new Menu("Burger", 50.00);
            Assert.AreEqual(menu[1], 50.0);
        }

        [TestMethod]
        public void Testnull()
        {
            Menu menu = new Menu(null,0);
            Assert.AreEqual(menu[0], "Not applicable");
        }

        [TestMethod]
        public void TestNegativePrice()
        {
            Menu menu = new Menu("Steak", -1);
            Assert.AreEqual(menu[1], 0.0);
        }

        [TestMethod]
        public void TestSetter()
        {
            Menu menu = new Menu("Steak", 50);
            menu[0] = "Pie";
            Assert.AreEqual(menu[0], "Pie");
        }
    }
}