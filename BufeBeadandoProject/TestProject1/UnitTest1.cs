using BufeBeadandoProject;


namespace TestProject1

{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            FoodOrderWindow foodOrderWindow = new FoodOrderWindow();
            foodOrderWindow.ActualPrice();
        }
    }
}