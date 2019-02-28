using Fundacion.Jala.Dev27.OscarCortez;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestsVector
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestSum()
        {
            string expectedResult = "[4,8]";
            Vector vector1 = new Vector(new List <int> { 1, 5 });
            Vector vector2 = new Vector(new List <int> { 3, 3 });
            string actualResult = vector1.Sum(vector2).Show();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDotProduct()
        {
            int expectedResult = 18;
            Vector vector1 = new Vector(new List<int> { 1, 5 });
            Vector vector2 = new Vector(new List<int> { 3, 3 });
            int actualResult = vector1.DotProduct(vector2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestLength()
        {
            Vector vector = new Vector(new List<int> { 2, 3 });
            var result = Math.Sqrt(Math.Pow(2, 2) + Math.Pow(3, 2));
            Assert.AreEqual(result, vector.Length());
        }

        [TestMethod]
        public void TestNoneNumberVector()
        {
            string[] args = { "1,4", "2,a"};
            
            ManagerData managerData = new ManagerData(args);
            //List<List<int>> convertedData = managerData.ConvertToListOfList();
            Assert.ThrowsException<ArgumentException>(() => managerData.ConvertToListOfList());
        }

        [TestMethod]
        public void TestValidVector()
        {
            string[] args = { "1,4", "2,3" , "7,6"};

            ManagerData managerData = new ManagerData(args);
            //List<List<int>> convertedData = managerData.ConvertToListOfList();
            Assert.ThrowsException<ArgumentException>(() => managerData.ConvertToListOfList());
        }
    }
}
