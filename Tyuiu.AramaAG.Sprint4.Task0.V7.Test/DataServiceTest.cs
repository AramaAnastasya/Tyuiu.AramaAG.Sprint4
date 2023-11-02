using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint4.Task0.V7.Lib;

namespace Tyuiu.AramaAG.Sprint4.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int res = ds.GetMultOddArrEl(numsArray);
            Assert.AreEqual(178605, res);
        }
    }
}
