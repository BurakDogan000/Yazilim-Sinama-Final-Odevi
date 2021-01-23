using System;
using istakipProgrami;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhiteBoxTest1
{
    [TestClass]
    public class GorevClassControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Gorev gorev = new Gorev();
            gorev.Aciklama = "adsf";
            gorev.Baslik = "gorev8";
            gorev.Id = 1;
            gorev.Durum = 3;
        }
    }
}
