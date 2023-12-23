using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint7.Project.V2.Lib;
namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        int[] testArray = { 1, 5, 2, 4, 8, 10, 7};

        [TestMethod]
        public void MinTest()
        {
            Assert.AreEqual(ds.MinCapital(ref testArray), 1);
        }

        [TestMethod]
        public void MaxTest()
        {
            Assert.AreEqual(ds.MaxCapital(ref testArray), 10);
        }

        [TestMethod]
        public void SumTest()
        {
            Assert.AreEqual(ds.SumCapital(ref testArray), 37);
        }

        [TestMethod]
        public void MeanTest()
        {
            Assert.AreEqual(ds.MeanCapital(ref testArray), 5);
        }
    }
}
