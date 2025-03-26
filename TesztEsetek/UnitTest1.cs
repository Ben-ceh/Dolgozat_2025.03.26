using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1.feladat;
using System;


namespace TesztEsetek
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod1()
        {
            //Arrange
            var szamol = new Rectangle();
            int width = 5;
            int height = 10;
            //Act
            double eredmeny = szamol.CalculateArea(width, height);
            //Assert
            Assert.AreEqual(50, eredmeny);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            //Arrange
            var szamol = new Rectangle();
            int width = 0;
            int height = 10;
            //Act
            double eredmeny = szamol.CalculateArea(width, height);
            //Assert
            Assert.AreEqual(0, eredmeny);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod3()
        {
            //Arrange
            var szamol = new Rectangle();
            int width = 10;
            int height = 0;
            //Act
            double eredmeny = szamol.CalculateArea(width, height);
            //Assert
            Assert.AreEqual(0, eredmeny);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod4()
        {
            //Arrange
            var szamol = new Rectangle();
            int width = -5;
            int height = 10;
            //Act
            double eredmeny = szamol.CalculateArea(width, height);
            //Assert
            

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod5()
        {
            //Arrange
            var szamol = new Rectangle();
            int width = 10;
            int height = -5;
            //Act
            double eredmeny = szamol.CalculateArea(width, height);
            //Assert
            

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod6()
        {
            //Arrange
            var szamol = new Rectangle();
            int width = 1000000;
            int height = 2000000;
            //Act
            double eredmeny = szamol.CalculateArea(width, height);
            //Assert
            Assert.AreEqual(2000000000000, eredmeny);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod7()
        {
            //Arrange
            var szamol = new Rectangle();
            double width = 4.5;
            double height = 8.2;
            //Act
            double eredmeny = szamol.CalculateArea(width, height);
            //Assert
            Assert.AreEqual(36.9, eredmeny);

        }


    }
}
