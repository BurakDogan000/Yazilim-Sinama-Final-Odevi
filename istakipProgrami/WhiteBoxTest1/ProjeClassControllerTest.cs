using System;
using istakipProgrami;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhiteBoxTest1
{
    [TestClass]
    public class ProjeClassControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Proje proje = new Proje();
            proje.Id = 2;
            proje.Projeİsmi = "YazılımSınamaFinal";
            proje.Musteri = "Burak";
            proje.Bilgi = "Proje ödevi yapımı";
        }
    }
}
