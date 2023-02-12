namespace zadanieEmployee.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            //arrange
            Employee employee1 = new Employee("Szymon", "Misiêniechce", 11);
            Employee employee2 = new Employee("Stanis³aw", "Nudzimisiê", 4);

            //act
            employee1.AddScore(1);
            employee1.AddScore(2);
            employee1.AddScore(3);
            employee1.SubtractScore(1);

            employee2.AddScore(2);
            employee2.SubtractScore(3);
            employee2.AddScore(1);
            employee2.AddScore(2);

            var result1 = employee1.Result;
            var result2 = employee2.Result;

            //assert (dowieœæ czegoœ)
            Assert.AreEqual(5, result1);
            Assert.AreEqual(2, result2);
            Assert.IsTrue(result1 > result2);


        }
    }
}