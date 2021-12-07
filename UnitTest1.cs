using Grabacion2PracticaVectoresINS368;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectGrabacion2PracticaVectoresINS368
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodMagnitud()
        {
            double result = Grabacion2PracticaVectoresINS368.Vector.Magnitud(2, 5);
            Assert.AreEqual(29, result);
        }

        [TestMethod]
        public void TestMethodDotProduct()
        {
            Vector objeto1 = new Vector(2, 5);
            Vector objeto2 = new Vector(1, 3);

            Assert.AreEqual(17, Vector.DotProduct(objeto1, objeto2));
        }

        [TestMethod]
        public void TestMethodAngleBetween()
        {
            Vector objeto1 = new Vector(2, 5);
            Vector objeto2 = new Vector(1, 3);

            Assert.AreEqual(0.05875582271572511, Vector.AngleBetween(objeto1,objeto2));
        }
    }
}