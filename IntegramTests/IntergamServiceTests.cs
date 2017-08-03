using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegramConn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegramConn.Tests
{
    [TestClass()]
    public class IntergamServiceTests
    {
        [TestMethod()]
        public void NotificarTelegramTest()
        {
            IIntegramServices srvIntegram = new IntegramService();
            Assert.IsTrue(srvIntegram.EnviarAlerta("dipi","Mensagem de teste de integração do Integram com o c#"));
        }
    }
}