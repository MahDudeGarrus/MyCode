using NUnit.Framework;
using System;
using System.Collections.Generic;

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


        [Test]
        public void ParseProperly_FromFile__ReturnStarClass()
        {
            var filePath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\StarsBeforeClassification.txt";
            var actualStars = FileManager.LoadStarFile(filePath);


            var expectedStars = new List<Star>();

            expectedStars.Add(new Star("Sun", 5800, 1, SpectralClass.G));
            expectedStars.Add(new Star("Betelgeuse", 3500, 11, SpectralClass.K));
            expectedStars.Add(new Star("Sirius", 9940, 2.02, SpectralClass.A));

            Assert.AreEqual(expectedStars[0].Name, actualStars[0].Name);
            Assert.AreEqual(expectedStars[1].Name, actualStars[1].Name);
            Assert.AreEqual(expectedStars[2].Name, actualStars[2].Name);

            Assert.AreEqual(expectedStars[0].Mass, actualStars[0].Mass);
            Assert.AreEqual(expectedStars[1].Mass, actualStars[1].Mass);
            Assert.AreEqual(expectedStars[2].Mass, actualStars[2].Mass);

            Assert.AreEqual(expectedStars[0].Temperature, actualStars[0].Temperature);
            Assert.AreEqual(expectedStars[1].Temperature, actualStars[1].Temperature);
            Assert.AreEqual(expectedStars[2].Temperature, actualStars[2].Temperature);

            Assert.AreEqual(expectedStars[0].SpectralClass, actualStars[0].SpectralClass);
            Assert.AreEqual(expectedStars[1].SpectralClass, actualStars[1].SpectralClass);
            Assert.AreEqual(expectedStars[2].SpectralClass, actualStars[2].SpectralClass);
        }


        [Test]
        public void GetStarClass_FromFile__ReturnStarClass()
        {
            var filePath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\StarsBeforeClassification.txt";
            var actualStars = FileManager.LoadStarFile(filePath);


            var expectedStars = new List<Star>();

            expectedStars.Add(new Star("Sun", 5800, 1, SpectralClass.G));
            expectedStars.Add(new Star("Betelgeuse", 3500, 11, SpectralClass.K));
            expectedStars.Add(new Star("Sirius", 9940, 2.02, SpectralClass.A));

            GetStarClass(actualStars);
            GetStarClass(expectedStars);

            Assert.AreEqual(expectedStars[0].StarClass, actualStars[0].StarClass);
            Assert.AreEqual(expectedStars[1].StarClass, actualStars[1].StarClass);
            Assert.AreEqual(expectedStars[2].StarClass, actualStars[2].StarClass);

        }


        private void GetStarClass(List<Star> stars)
        {
            foreach (Star star in stars)
            {

                star.GetStarClass();

            }
        }
    }
}
