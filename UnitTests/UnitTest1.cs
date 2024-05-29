using BufeBeadandoProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

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
        /// Szabolcs - unit testek
        /// </summary>
       
        private string filePath = "./Users.csv";

        [TestInitialize]
        public void TestInitialize()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, string.Empty);
            }
        }

        [TestMethod]
        public void ValidateUsername_WithShortUsername_ReturnsFalse()
        {
            RegWindow instance = new RegWindow();
            bool result = instance.ValidateUsername("asd");
            Assert.IsFalse(result);
            Assert.AreEqual("Nem megfelelő hosszúságú felhasználónév!", instance.ErrorMessageLabel.Text);
        }

        [TestMethod]
        public void ValidateUsername_WithExistingUsername_ReturnsFalse()
        {
            File.WriteAllText(filePath, "SzabolcsTest;jelszohelye\n");
            RegWindow instance = new RegWindow();
            bool result = instance.ValidateUsername("SzabolcsTest");
            Assert.IsFalse(result);
            Assert.AreEqual("Már ilyen felhasználónévvel van regisztrálva felhasználó!", instance.ErrorMessageLabel.Text);
        }

        [TestMethod]
        public void ValidatePassword_WithShortPassword_ReturnsFalse()
        {
            RegWindow instance = new RegWindow();
            bool result = instance.ValidatePassword("1234", "1234");
            Assert.IsFalse(result);
            Assert.AreEqual("Nem megfelelő hosszúságú jelszó!", instance.ErrorMessageLabel.Text);
        }

        [TestMethod]
        public void ValidatePassword_WithNonMatchingPasswords_ReturnsFalse()
        {
            RegWindow instance = new RegWindow();
            bool result = instance.ValidatePassword("jelszo1", "jelszo2");
            Assert.IsFalse(result);
            Assert.AreEqual("Nem egyező jelszó!", instance.ErrorMessageLabel.Text);
        }

        [TestMethod]
        public void ValidatePassword_WithValidPasswords_ReturnsTrue()
        {
            RegWindow instance = new RegWindow();
            bool result = instance.ValidatePassword("jelszo", "jelszo");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateEmail_WithInvalidEmail_ReturnsFalse()
        {
            RegWindow instance = new RegWindow();
            bool result = instance.ValidateEmail("rosszemail");
            Assert.IsFalse(result);
            Assert.AreEqual("Nem megfelelő email!", instance.ErrorMessageLabel.Text);
        }

        [TestMethod]
        public void ValidateEmail_WithValidEmail_ReturnsTrue()
        {
            RegWindow instance = new RegWindow();
            bool result = instance.ValidateEmail("test@email.com");
            Assert.IsTrue(result);
        }

    }
}
