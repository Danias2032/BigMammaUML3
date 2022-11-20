using BigMammaUML3;

namespace BigMammaUML3Test
{
    [TestClass]
    public class MenuCatalogTest
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();
            Pizza p1 = new Pizza(1, "Magarita", "Tomato & Cheese", 75.0, MenuType.Pizza, false, true, true);
            Pizza p2 = new Pizza(2, "Hawaii", "Tomato & Cheese & Annanas", 75.0, MenuType.Pizza, false, true, false);

            //Act
            int antalBefore = catalog.Count;
            catalog.Add(p1);
            catalog.Add(p2);
            int antalAfter = catalog.Count;
            //Assert

            Assert.AreEqual(antalBefore +2, antalAfter);
        }

        [TestMethod]
        public void TestDelete()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();
            Pizza p3 = new Pizza(3, "Magarita", "Tomato & Cheese", 75.0, MenuType.Pizza, false, true, true);
            Pizza p4 = new Pizza(4, "Hawaii", "Tomato & Cheese & Annanas", 75.0, MenuType.Pizza, false, true, false);
            //Act
            int beforeDelete = catalog.Count;
            catalog.Add(p3);
            catalog.Add(p4);
            catalog.Delete(4);
            int afterDelete = catalog.Count;

            //Assert
            Assert.AreNotEqual(beforeDelete, afterDelete);
        }
        
    }
}