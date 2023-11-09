using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint4.Task5.V20.Lib;

namespace Tyuiu.AramaAG.Sprint4.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] numsArray = new int[5, 5] { { -1, -7, 2, -6, 3 }, { -4, 4, -4, -2, -4 }, { -5, 5, -5, -6, -5 }, { -4, -2, -5, -2, 1 }, { -6, -2, 3, -6, -7 } };
            int res = ds.Calculate(numsArray);
            int wait = 18;
            Assert.AreEqual(wait, res);
        }
    }
}
