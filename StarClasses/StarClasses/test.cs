using NUnit.Framework;

namespace StarClasses
{


    [TestFixture]
    class test
    {

        [SetUp]

        public void SetUp()
        {


        }

        [Test]

        public void GetStarClass_Sun_ReturnStarClass()
        {
            var star = new Star(name: "Sun", temp: 5800, mass: 1, absolutem: 4.83, distance: "147.4 million miles", age: "4.603 billion years"); 
            var value = star.GetStarClass();
            var expected = StarClass.Mainsequence2;
            
            Assert.AreEqual(expected, value);

        }

        [Test]
        public void GetStarClass_Betelgeuse__ReturnStarClass()
        {
            var star = new Star(name: "Betelgeuse", temp: 3500, mass: 11, absolutem: -5.85, distance: "642.5 light years", age: "10.01 million years");
            var value = star.GetStarClass();
            var expected = StarClass.Supergiant;

            Assert.AreEqual(expected, value);

        }
    }
}
