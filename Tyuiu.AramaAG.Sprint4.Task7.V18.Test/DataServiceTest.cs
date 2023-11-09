using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint4.Task7.V18.Lib;

namespace Tyuiu.AramaAG.Sprint4.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int rows = 5;
            int column = 3;
            string str = "145258749635789";
            int res = ds.Calculate(rows, column, str);
            int wait = 12288;
            Assert.AreEqual(wait, res);
        }
    }
}
