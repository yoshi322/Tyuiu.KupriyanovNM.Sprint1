using Tyuiu.KupriyanovNM.Sprint1.Task4.V2.Lib;
namespace Tyuiu.KupriyanovNM.Sprint1.Task4.V2.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
