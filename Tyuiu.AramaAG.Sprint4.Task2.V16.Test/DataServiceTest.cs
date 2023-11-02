using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint4.Task2.V16.Lib;

namespace Tyuiu.AramaAG.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 6, 6, 9, 6, 9, 3, 9, 5, 7, 4 };
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(42, res);
        }
    }
}
