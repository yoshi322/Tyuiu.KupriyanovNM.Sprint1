using Tyuiu.KupriyanovNM.Sprint1.Task6.V5.Lib;
namespace Tyuiu.KupriyanovNM.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "казак . , ? ! : ;";
            DataService ds = new DataService();
            string res = ds.CheckSymmetricalWords(strTest);
            string wait = "казак";
            Assert.AreEqual(wait, res);
        }
    }
}
