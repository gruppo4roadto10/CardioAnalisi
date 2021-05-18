using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FrequenzaConsiglita()
        {
            int eta = 20;
            string valoreAspettato = "Battiti massimi:180. Battiti minimi:140";
            string valoreRitorno = DataCardio.FrequenzaBattitiConsigliata(eta);
            Assert.AreEqual(valoreAspettato, valoreRitorno);

        }
        [TestMethod]
        public void BattitiBradicardiaco()
        {
            int battiti = 50;
            bool valoreAspettato = true;
            bool valoreRitorno = DataCardio.Bradicardiaco(battiti);
            Assert.AreEqual(valoreAspettato, valoreRitorno);

        }
        public void BattitiBradicardiaco1()
        {
            int battiti = 70;
            bool valoreAspettato = false;
            bool valoreRitorno = DataCardio.Bradicardiaco(battiti);
            Assert.AreEqual(valoreAspettato, valoreRitorno);

        }

        [TestMethod]
        public void BattitiNormale()
        {
            int battiti = 80;
            bool valoreAspettato = true;
            bool valoreRitorno = DataCardio.Normale(battiti);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void BattitiNormale1()
        {
            int battiti = 120;
            bool valoreAspettato = false;
            bool valoreRitorno = DataCardio.Normale(battiti);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }

        [TestMethod]
        public void BattitiTachicardiaco()
        {
            int battiti = 110;
            bool valoreAspettato = true;
            bool valoreRitorno = DataCardio.Tachicardia(battiti);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void BattitiTachicardiaco1()
        {
            int battiti = 90;
            bool valoreAspettato = false;
            bool valoreRitorno = DataCardio.Tachicardia(battiti);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void CalorieBruciateUomo()
        {
            double a = 30, p = 70, t = 30, f = 80;
            double valoreAspettato = 110.10;
            double valoreRitorno = DataCardio.CalorieUomo(a, p, f, t);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void CalorieBruciateDonna()
        {
            double a = 25, p = 50, t = 40, f = 90;
            double valoreAspettato = 2;
            double valoreRitorno = DataCardio.CalorieUomo(a, p, f, t);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void Corsa()
        {
            double kmpercorsi = 10, pesocorporeo = 60;
            double valoreAspettato = 540;
            double valorefisso = 0.9;
            double valoreRitorno = DataCardio.CalorieCorsa(kmpercorsi, pesocorporeo);
            Assert.AreEqual(valoreAspettato,valoreRitorno,valorefisso);




        }
        [TestMethod]
        public void Camminata()
        {
            double kmpercorsi = 20, pesocorporeo = 70;
            double valoreAspettato = 700;
            double valoreFisso = 0.50;
            double valoreRitorno = DataCardio.CalorieCamminata(kmpercorsi, pesocorporeo);
            Assert.AreEqual(valoreAspettato, valoreRitorno, valoreFisso);

        }
        [TestMethod]
        public void MediaBattitiGiornaliera()
        {


        }
        [TestMethod]
        public void BattitoCardiacoRiposo()
        {


        }
        [TestMethod]
        public void Varabilt‡Battito()
        {


        }



    }
}
