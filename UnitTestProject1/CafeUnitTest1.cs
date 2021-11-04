using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class CafeUnitTest1
    {
        MenuRepo menuRepo;

        [TestInitialize]
        public void Arrange()
        {
            menuRepo = new MenuRepo();
        }

        [TestMethod]
        public void AddItemToMenu_Test()
        {
            MenuItem item = new MenuItem();
            bool result = menuRepo.AddItemToMenu(item);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public bool DeleteExistingItem_Test(MenuItem existingItem)
        {
            MenuItem item = new MenuItem();
            item.MealName = "Burger";
            menuRepo.AddItemToMenu(item);

            bool actual = menuRepo.DeleteExistingItem("Burger");
            bool expected = true;
            Assert.AreEqual(actual, expected); 
        }
    }
}

//Arrange - everything we need for method to run ( where is it {create instance}, what parameters{new instance})
// Act - calling method and parameters
// Assert - whatever we return is what we expected