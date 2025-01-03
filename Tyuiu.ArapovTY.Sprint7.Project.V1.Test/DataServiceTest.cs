﻿using Tyuiu.ArapovTY.Sprint7.Project.V1.Lib;
namespace Tyuiu.ArapovTY.Sprint7.Project.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void GetMaxValue()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int res = ds.GetMaxValue(array);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void GetMinValue()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int res = ds.GetMinValue(array);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void GetAvgValue()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            double res = ds.GetAvgValue(array);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }

    }
}
