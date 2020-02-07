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

        [Test]
        public void GetStarClass_Sirius__ReturnStarClass()
        {
            var star = new Star(name: "Sirius", temp: 9940, mass: 2.02, absolutem: -1.46, distance: "8.6 light years", age: "300 million years");
            var value = star.GetStarClass();
            var expected = StarClass.Mainsequence3;

            Assert.AreEqual(expected, value);

        }

        [Test]
        public void GetStarClass_Aldebaran__ReturnStarClass()
        {
            var star = new Star(name: "Aldebaran", temp: 3910, mass: 1.7, absolutem: -2.1, distance: "65.2 light years", age: "6.605 billion years");
            var value = star.GetStarClass();
            var expected = StarClass.Giant;

            Assert.AreEqual(expected, value);

        }

        [Test]
        public void GetStarClass_Rigel__ReturnStarClass()
        {
            var star = new Star(name: "Rigel", temp: 11000, mass: 18, absolutem: .12, distance: "864.3 light years", age: "8.005 billion years");
            var value = star.GetStarClass();
            var expected = StarClass.Mainsequence3;

            Assert.AreEqual(expected, value);

        }

        [Test]
        public void GetStarClass_ProximaCentauri__ReturnStarClass()
        {
            var star = new Star(name: "Proxima Centauri", temp: 3042, mass: .123, absolutem: 11.02, distance: "4.243 light years", age: "4.853 billion years");
            var value = star.GetStarClass();
            var expected = StarClass.Mainsequence1;

            Assert.AreEqual(expected, value);

        }
    }
}
