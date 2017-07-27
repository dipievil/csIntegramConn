using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegramServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegramServices.Tests
{
    [TestClass()]
    public class IntergamServiceTests
    {
        [TestMethod()]
        public void NotificarTelegramTest()
        {
            IIntegramServices srvIntegram = new IntegramServices();
            Assert.IsTrue(srvIntegram.EnviarAlerta("dipi","Teste"));
        }
    }
}