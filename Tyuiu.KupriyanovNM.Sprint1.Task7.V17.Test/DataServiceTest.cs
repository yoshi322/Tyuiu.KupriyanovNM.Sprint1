using Tyuiu.KupriyanovNM.Sprint1.Task7.V17.Lib;
namespace Tyuiu.KupriyanovNM.Sprint1.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = -13.662;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
