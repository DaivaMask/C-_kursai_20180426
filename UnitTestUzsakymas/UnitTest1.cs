using System;
using _16___2_testavimas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUzsakymas
{
    [TestClass]
    public class UnitTestUzsakymas
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ProcessOrder_SiuntaJauIssiusta_ThrowExeption() //nurodom metoda, kuri kviesim - kokia informacija bus patiekiama - kokios informacijos tikimes
        {
            Uzsakymas uzsakymas = new Uzsakymas(
                new Siuntimas(false)
                );
            uzsakymas.ProceddOrder();
        }

        [TestMethod]
        public void ProcessOrder_SiuntaDarNeissiusta_Gausim4()
        {
            Uzsakymas uzsakymas = new Uzsakymas(new FakeSiunta());
            uzsakymas.ProceddOrder();
            Assert.AreEqual(uzsakymas.Kaina, 24);


        }
    }

    class FakeSiunta : ISiuntimas
    {
        public bool IsShipped { get; }

        public int SiuntosSkaiciuotuvas()
        {
            return 4;

        }

    }
}
