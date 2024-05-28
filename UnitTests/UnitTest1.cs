using BufeBeadandoProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Levente - ételrendelés - unit testek
        /// </summary>
        
        [TestMethod]
        public void ActualPriceForUnitTest_WhenNoMenuOrDessertSelected_ReturnsZero()
        {
            FoodOrderWindow instance = new FoodOrderWindow();

            instance.ActualPriceForUnitTest(0, 0, 0, 0, 0);

            int expectedPrice = 0;
            Assert.AreEqual(expectedPrice, instance.priceSummary);
        }

        [TestMethod]
        public void ActualPriceForUnitTest_WhenTheCostumerPaysMaximum()
        {
            FoodOrderWindow instance = new FoodOrderWindow();

            instance.ActualPriceForUnitTest(5, 5, 0, 0, 5);

            int expectedPrice = 10500;
            Assert.AreEqual(expectedPrice, instance.priceSummary);
        }

        [TestMethod]
        public void ActualPriceForUnitTest_OnlyMealAndSalt()
        {
            FoodOrderWindow instance = new FoodOrderWindow();

            instance.ActualPriceForUnitTest(5, 0, 5, 0, 0);

            int expectedPrice = 7750;
            Assert.AreEqual(expectedPrice, instance.priceSummary);
        }

        [TestMethod]
        public void ActualPriceForUnitTest_OnlyMealAndPepper()
        {
            FoodOrderWindow instance = new FoodOrderWindow();

            instance.ActualPriceForUnitTest(5, 0, 0, 5, 0);

            int expectedPrice = 7800;
            Assert.AreEqual(expectedPrice, instance.priceSummary);
        }

        [TestMethod]
        public void ActualPriceForUnitTest_OnlyMealAndBothFlavor()
        {
            FoodOrderWindow instance = new FoodOrderWindow();

            instance.ActualPriceForUnitTest(5, 0, 0, 0, 5);

            int expectedPrice = 8000;
            Assert.AreEqual(expectedPrice, instance.priceSummary);
        }

        [TestMethod]
        public void ActualPriceForUnitTest_OnlyMeal()
        {
            FoodOrderWindow instance = new FoodOrderWindow();

            instance.ActualPriceForUnitTest(5, 0, 0, 0, 0);

            int expectedPrice = 7500;
            Assert.AreEqual(expectedPrice, instance.priceSummary);
        }

        [TestMethod]
        public void ActualPriceForUnitTest_OnlyDessert()
        {
            FoodOrderWindow instance = new FoodOrderWindow();

            instance.ActualPriceForUnitTest(0, 5, 0, 0, 0);

            int expectedPrice = 2500;
            Assert.AreEqual(expectedPrice, instance.priceSummary);
        }

        /// <summary>
        /// Szabolcs - XY - unit testek
        /// </summary>

    }
}
