using Microsoft.VisualStudio.TestTools.UnitTesting;
using MATINFO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO.Model.Tests
{
    [TestClass()]
    public class AttributionTests
    {

        [TestInitialize()]
        public void Init()
        {
            Attribution attribution = new Attribution("je suis un commentaire", new DateTime(1972, 1, 1), 1, 1);
        }


        [TestMethod()]
        public void AttributionTest()
        {
            Attribution attribution = new Attribution("je suis un commentaire", new DateTime(1974, 1, 1), 1, 1);
            Attribution atr = new Attribution("je suis un commentaire", new DateTime(DateTime.Today.Year+1, DateTime.Today.Month, DateTime.Today.Day), 1, 1);
            Assert.IsTrue(attribution.DateAttribution.Year >= 1973, "ce n'est pas plus grand que 1973");
            Assert.IsTrue(attribution.DateAttribution <= DateTime.Today, "ce n'est pas plus petit que la date d'aujourd'hui");
        }


    }
}