using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint3.Task2.V12.Lib;
namespace Tyuiu.RachevES.Sprint3.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();
            int value, startValue, stopValue;
            value = 5; startValue = 1; stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 0.033;

            Assert.AreEqual(wait, res);
        }
    }
}
