using System;
using istakipProgrami;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhiteBoxTest1
{
    [TestClass]
    public class KullaniciClassControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Id = 1;
            kullanici.Adi = "Ahmet";
            kullanici.Soyadi = "Tahsildaroğlu";
            kullanici.KullaniciAdi = "ahmetTah";
            kullanici.Parola = "12";
        }
    }
}
