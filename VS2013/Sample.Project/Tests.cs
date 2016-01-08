using NUnit.Framework;

namespace Sample.Project
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void SampleData()
        {
            Test(null, 0);
        }

        private void Test(int[] input, int expected)
        {
            var sample = new Sample();
            var actual = sample.Run(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
