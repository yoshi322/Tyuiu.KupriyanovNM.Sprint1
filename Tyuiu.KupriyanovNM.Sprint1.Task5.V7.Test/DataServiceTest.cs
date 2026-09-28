using Tyuiu.KupriyanovNM.Sprint1.Task5.V7.Lib;
namespace Tyuiu.KupriyanovNM.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double f = 30;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(f);
            int result = Convert.ToInt32(res);
            int h = 1;
            Assert.AreEqual(h, result);
        }
    }
}
