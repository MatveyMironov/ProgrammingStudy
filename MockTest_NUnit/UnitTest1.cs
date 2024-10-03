using NSubstitute;

namespace MockTest_NUnit
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var mock = Substitute.For<INumberService>();
            mock.Ints().Returns([1, 2, 3]);
            var numberProcessor = new NumberProcessor(mock);

            var sum = numberProcessor.CalculateSum();
            var average = numberProcessor.CalculateAverage();
            
            Assert.That(sum, Is.EqualTo(6));
            Assert.That(average, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var mock = Substitute.For<INumberService>();
            mock.Ints().Returns([]);
            var numberProcessor = new NumberProcessor(mock);

            var sum = numberProcessor.CalculateSum();
            var average = numberProcessor.CalculateAverage();

            Assert.That(sum, Is.EqualTo(0));
            Assert.That(average, Is.EqualTo(0));
        }
    }
}