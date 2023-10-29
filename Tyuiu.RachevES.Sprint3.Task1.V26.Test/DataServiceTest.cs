using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint3.Task1.V26.Lib;
namespace Tyuiu.RachevES.Sprint3.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value, startValue, stopValue;
            value = 5; startValue = 1; stopValue = 8;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 1.50;
            Assert.AreEqual(wait, res);
        }
    }
}
