using Tyuiu.KupriyanovNM.Sprint1.Task0.V0.Lib;
namespace Tyuiu.KupriyanovNM.Sprint1.Task0.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
