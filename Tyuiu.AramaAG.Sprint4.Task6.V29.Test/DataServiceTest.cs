using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint4.Task6.V29.Lib;

namespace Tyuiu.AramaAG.Sprint4.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var Seasons = new string[] { "Весна", "Лето", "Осень", "Зима" };
            int res = ds.Calculate(Seasons);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
